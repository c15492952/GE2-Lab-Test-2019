using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float tiberium = 0;

    public TextMeshPro text;

    public GameObject fighterPrefab;

    public GameObject target1;
    public GameObject target2;
    public GameObject target3;

    private Renderer shiprend;
    private Component seek;
    Color teamColor;

    // Start is called before the first frame update
    void Start()
    {
        teamColor = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.material.color = teamColor;
        }
        StartCoroutine("AddTiberium");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + tiberium;
        
       

        if(tiberium >= 10)
        {
            int TargPick = Random.Range(1, 3);
            if (TargPick == 1)
            {
                tiberium -= 10;
                GameObject ship = Instantiate(fighterPrefab, transform.position, Quaternion.LookRotation(target1.transform.position, Vector3.up));
                ship.AddComponent<Renderer>();
                shiprend = ship.GetComponent<Renderer>();
                shiprend.material.color = teamColor;

                ship.AddComponent<Boid>();
                ship.AddComponent<Arrive>();
                ship.AddComponent<Seek>();
                ship.GetComponent<Seek>().targetGameObject = target1;
            }
            else if(TargPick == 2)
            {
                tiberium -= 10;
                GameObject ship = Instantiate(fighterPrefab, transform.position, Quaternion.LookRotation(target1.transform.position, Vector3.up));
                ship.AddComponent<Renderer>();
                shiprend = ship.GetComponent<Renderer>();
                shiprend.material.color = teamColor;

                ship.AddComponent<Boid>();
                ship.AddComponent<Arrive>();
                ship.AddComponent<Seek>();
                ship.GetComponent<Seek>().targetGameObject = target2;
            }
            else if(TargPick ==3)
            {
                tiberium -= 10;
                GameObject ship = Instantiate(fighterPrefab, transform.position, Quaternion.LookRotation(target1.transform.position, Vector3.up));
                ship.AddComponent<Renderer>();
                shiprend = ship.GetComponent<Renderer>();
                shiprend.material.color = teamColor;

                ship.AddComponent<Boid>();
                ship.AddComponent<Arrive>();
                ship.AddComponent<Seek>();
                ship.GetComponent<Seek>().targetGameObject = target3;
            }
               
        }
    }

    IEnumerator AddTiberium()
    {
        for(;;)
        {
            tiberium += 1;
            yield return new WaitForSeconds(1);
        }
    }
}
