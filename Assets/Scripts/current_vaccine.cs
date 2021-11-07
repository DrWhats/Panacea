using UnityEngine;

public class current_vaccine : MonoBehaviour
{

    public int Elem_1 = 0;
    public int Elem_2 = 0;
    public int Elem_3 = 0;
    public int Elem_4 = 0;

    public int[] _effectiveElements = new int[4];
    
    [SerializeField] private bar_indicator bar;
    [SerializeField] private AudioSource audio;
    private AudioClip Clip;

    private void OnTriggerEnter2D(Collider2D other)
    {

        Clip = other.gameObject.GetComponent<AudioSource>().clip;
        audio.clip = Clip; 
        audio.Play();

        if (Elem_1 == 0)
        {
            Elem_1 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
            bar.bar_1();
            this.gameObject.GetComponent<Animator>().Play("object_insert");

        } else if (Elem_2 == 0)
        {
            Elem_2 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
            bar.bar_2();
            this.gameObject.GetComponent<Animator>().Play("object_insert");
        } else if(Elem_3 == 0)
        {
            Elem_3 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
            bar.bar_3();
            this.gameObject.GetComponent<Animator>().Play("object_insert");
        }
        else if (Elem_4 == 0)
        {
            Elem_4 = other.gameObject.GetComponent<element>().id;
            other.gameObject.SetActive(false);
            bar.bar_4();
            this.gameObject.GetComponent<Animator>().Play("object_insert");
            
        }
        
        
    }

    void Start()
    {
        _effectiveElements[0] = Random.Range(1, 3);
        _effectiveElements[1] = Random.Range(4, 6);
        _effectiveElements[2] = Random.Range(7, 9);
        _effectiveElements[3] = Random.Range(10, 12);
        
    }

    public bool check_vac()
    {
        if (Elem_1 != 0)
        {
            return (true);
        }
        else return (false);
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