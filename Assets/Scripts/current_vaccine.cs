using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class current_vaccine : MonoBehaviour
{

    private int Elem_1 = 0;
    private int Elem_2 = 0;
    private int Elem_3 = 0;
    private int Elem_4 = 0;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Elem_1 == 0)
        {
            Elem_1 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
        } else if (Elem_2 == 0)
        {
            Elem_2 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
        } else if(Elem_3 == 0)
        {
            Elem_3 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
        }else if (Elem_4 == 0)
        {
            Elem_4 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
        }
        
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
