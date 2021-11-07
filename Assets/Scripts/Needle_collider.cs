
using UnityEngine;


public class Needle_collider : MonoBehaviour
{

    [SerializeField] private minigameCurrentPatient game;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("NEEDLE");
        if (other.gameObject.transform.tag == "aim")
        {
           
            game.NeedleSuccess();
        }
        
        
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
