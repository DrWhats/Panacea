using UnityEngine;

public class detect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("detected");
    }
}

