using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Patien_gen : MonoBehaviour
{

    [SerializeField] GameObject[] _patientCards = new GameObject[10];

    private string[] _patientNames = { "Василий", "Петр", "Кирилл", "Диана", "Екатерина", "Полина", "Данил", "Олег"};
    void Start()
    {
        foreach (var card in _patientCards)
        {
            var text_name = card.transform.Find("Patient_name").gameObject.GetComponent<Text>();
            int element = Random.Range(0, _patientNames.Length);
            text_name.text = _patientNames[element];
            
            var text_age = card.transform.Find("Patient_age").gameObject.GetComponent<Text>();
            text_age.text = Random.Range(20, 30).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
