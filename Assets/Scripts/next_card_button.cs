using UnityEngine;

public class next_card_button : MonoBehaviour
{
    [SerializeField] GameObject[] _patientCards = new GameObject[10];

    public void next_card()
    {
        for (int i = 0; i < _patientCards.Length - 1; i++)
        {
            if (i == _patientCards.Length - 1)
            {
                break;
            }
            if (_patientCards[i].active == false)
            {

            }
            if (_patientCards[i].active == true)
            {
                _patientCards[i].SetActive(false);
                i++;
                _patientCards[i].SetActive(true);
                break;
            }
        }
    }

}