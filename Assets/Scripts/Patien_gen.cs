using UnityEngine;
using UnityEngine.UI;

public class Patien_gen : MonoBehaviour
{

    [SerializeField] GameObject[] _patientCards = new GameObject[10];

    private string[] _patientNames = { "Василий", "Петр", "Кирилл", "Диана", "Екатерина", "Полина", "Данил", "Олег", "Лев" };
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

            card.GetComponent<Patient_info>().setName(_patientNames[Random.Range(0, _patientNames.Length)]);
            card.GetComponent<Patient_info>().setAge(Random.Range(20, 30).ToString());
        }
    }
}