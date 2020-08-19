using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 0;
    int rm = 0;


    // Start is called before the first frame update
    void Start()
    {
        rm = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(gameObject.name + ":" + i);
        i++;


        if (i == 100)
            GameObject.FindWithTag("Red").active = false;

        
        
        if (i == rm )
            GameObject.FindWithTag("Blue").active = false;
    }
}
