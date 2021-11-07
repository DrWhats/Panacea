using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Color startColor;
    public Color mouseOverColor;
    private bool mouseOver = false;

    void OnMouseEnter()
    {
        mouseOver = true;
        GetComponent<SpriteRenderer>().material.SetColor("_Color", mouseOverColor);
    }
    void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<SpriteRenderer>().material.SetColor("_Color",startColor);
    }
}
