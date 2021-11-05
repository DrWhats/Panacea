using UnityEngine;

public class prev_card_button : MonoBehaviour
{
    [SerializeField] GameObject[] _patientCards = new GameObject[10];

    public void back_card()
    {
        for (int i = _patientCards.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                break;
            }
            if (_patientCards[i].active == false)
            {

            }
            if (_patientCards[i].active == true)
            {
                _patientCards[i].SetActive(false);
                i--;
                _patientCards[i].SetActive(true);
                break;
            }
        }
    }

}