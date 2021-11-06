using UnityEngine;
using UnityEngine.UI;

public class Patien_gen : MonoBehaviour
{

    [SerializeField] GameObject[] _patientCards = new GameObject[10];

    private string[] _patientNamesFemale = 
        { "Диана", "Екатерина", "Полина", "Алиса", "Ксения", "Марина", "Мария", "Кира", "Ирина", "Вероника"};

    private string[] _patientNamesMale =
        { "Василий", "Петр", "Кирилл", "Данил", "Олег", "Лев", "Руслан", "Юрий", "Анатолий", "Константин" };
    
    void Start()
    {
        for (int i = 0; i <= _patientCards.Length - 1; i++)
        {
            if (i == 0)
            {
                _patientCards[i].SetActive(true);
            }
            else
            {
                _patientCards[i].SetActive(false);
            }
        }
        
        foreach (var card in _patientCards)
        {
            Debug.Log("PATIENT");
            
            var patient = card.GetComponent<Patient_info>();
            patient.setAge(Random.Range(20, 30).ToString());
            patient.setSex();
            Debug.Log(patient.sex);
            
            if (patient.sex == true)
            {
                patient.setName(_patientNamesFemale[Random.Range(0, _patientNamesFemale.Length-1)]);
                Debug.Log("ТЁЛКА");
                
            }
            else if (patient.sex == false)
            {
                patient.setName(_patientNamesMale[Random.Range(0, _patientNamesMale.Length-1)]);
                Debug.Log("МУЖЫЫЫК");
            }
            
            patient.setPicture();
        }
        
        
    }
}