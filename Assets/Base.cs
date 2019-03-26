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

        sendShip();        
    }

    IEnumerator AddTiberium()
    {
        for(;;)
        {
            tiberium += 0.5f;
            yield return new WaitForSeconds(0.5f);
        }
    }


    public void sendShip()
    {
        if (tiberium >= 10)
        {
            int TargPick = Random.Range(1, 3);
            if (TargPick == 1)
            {
                tiberium -= 10;
                GameObject ship = Instantiate(fighterPrefab, transform.position, transform.rotation);
                ship.transform.LookAt(target1.transform.position);
                ship.AddComponent<Renderer>();
                shiprend = ship.GetComponent<Renderer>();
                shiprend.material.color = teamColor;
                ship.AddComponent<Boid>();
                ship.AddComponent<Arrive>();
                ship.AddComponent<Seek>().targetGameObject = target1;


                //Component trigger = target1.GetComponent<CapsuleCollider>().;
                //ON Trigger enter - Shoot bullets at Base
                //Then
                /*
                Destroy(ship.GetComponent<Seek>());
                ship.AddComponent<Seek>().targetGameObject = this;
                if(tiberium > 7)
                {
                    tiberium -= 7;
                    Destroy(ship.GetComponent<Seek>());
                    
                    sendship()
                }
                else{
                    Destroy(ship);
                }
                */

            }
            else if (TargPick == 2)
            {
                tiberium -= 10;
                GameObject ship = Instantiate(fighterPrefab, transform.position, transform.rotation);
                ship.transform.LookAt(target2.transform.position);
                ship.AddComponent<Renderer>();
                shiprend = ship.GetComponent<Renderer>();
                shiprend.material.color = teamColor;

                ship.AddComponent<Boid>();
                ship.AddComponent<Arrive>();
                ship.AddComponent<Seek>();
                ship.GetComponent<Seek>().targetGameObject = target2;

                //Component trigger = target1.GetComponent<CapsuleCollider>().;
                //ON Trigger enter - Shoot bullets at Base
                //Then
                /*
                Destroy(ship.GetComponent<Seek>());
                ship.AddComponent<Seek>().targetGameObject = this;
                if(tiberium > 7)
                {
                    tiberium -= 7;
                    Destroy(ship.GetComponent<Seek>());
                    
                    sendship()
                }
                else{
                    Destroy(ship);
                }
                */
            }
            else if (TargPick == 3)
            {
                tiberium -= 10;
                GameObject ship = Instantiate(fighterPrefab, transform.position, transform.rotation);
                ship.transform.LookAt(target3.transform.position);
                ship.AddComponent<Renderer>();
                shiprend = ship.GetComponent<Renderer>();
                shiprend.material.color = teamColor;

                ship.AddComponent<Boid>();
                ship.AddComponent<Arrive>();
                ship.AddComponent<Seek>();
                ship.GetComponent<Seek>().targetGameObject = target3;

                //Ran out of time.. heres a description

                //Component trigger = target1.GetComponent<CapsuleCollider>().;
                //ON Trigger enter - Shoot bullets at Base
                //Then
                
            
            /*
                Destroy(ship.GetComponent<Seek>());
                ship.AddComponent<Seek>().targetGameObject = this;
                if(tiberium > 7)
                {
                    tiberium -= 7;
                    Destroy(ship.GetComponent<Seek>());
                    
                    sendship()
                }
                else{
                    Destroy(ship);
                }
                */
            }

        }
    }
}
