
using System.Collections.Generic;
using UnityEngine;

public class toDefault : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject[] _objects = new GameObject[12];
    private Dictionary<GameObject, Vector3> _positions = new Dictionary<GameObject, Vector3>();
    void Start()
    {
        foreach (GameObject obj in _objects)
        {
            _positions.Add(obj, obj.GetComponent<Transform>().position);
        }
    }

    public void ResetElements()
    {
        foreach (var pair in _positions)
        {
            pair.Key.transform.position = pair.Value;
            pair.Key.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
