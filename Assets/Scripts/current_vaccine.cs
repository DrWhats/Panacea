using UnityEngine;

public class current_vaccine : MonoBehaviour
{

    public int Elem_1 = 0;
    public int Elem_2 = 0;
    public int Elem_3 = 0;
    public int Elem_4 = 0;

    [SerializeField] private bar_indicator bar;


    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (Elem_1 == 0)
        {
            Elem_1 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
            bar.bar_1();
        } else if (Elem_2 == 0)
        {
            Elem_2 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
            bar.bar_2();
        } else if(Elem_3 == 0)
        {
            Elem_3 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
            bar.bar_3();
        }
        else if (Elem_4 == 0)
        {
            Elem_4 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
            bar.bar_4();
        }
        
        
    }

    public void resetElements()
    {
            Elem_1 = 0;
            Elem_2 = 0;
            Elem_3 = 0;
            Elem_4 = 0;
            bar.bar_selector();
    }
}