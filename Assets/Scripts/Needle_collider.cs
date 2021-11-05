using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class Needle_collider : MonoBehaviour
{

    [SerializeField] private minigameCurrentPatient game;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("NEEDLE");
        game.NeedleSuccess();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
