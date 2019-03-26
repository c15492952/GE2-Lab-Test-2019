﻿using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + tiberium;
        StartCoroutine("AddTiberium");

        if(tiberium >= 10)
        {
            //Instantiate(fighterPrefab, new Vector3(0, 0, 0), );
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
