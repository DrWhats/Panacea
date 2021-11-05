using UnityEngine;

public class current_vaccine : MonoBehaviour
{

    private int Elem_1 = 0;
    private int Elem_2 = 0;
    private int Elem_3 = 0;
    private int Elem_4 = 0;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
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
}