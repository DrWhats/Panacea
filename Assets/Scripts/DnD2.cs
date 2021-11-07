using UnityEngine;
 
[RequireComponent(typeof(BoxCollider2D))]
public class DnD2 : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public AudioSource audio;

    void OnMouseDown()
    {

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    public void sound_play()
    {
        audio.Play();
    }
}