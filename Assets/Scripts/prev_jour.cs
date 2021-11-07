using UnityEngine;
using UnityEngine.Serialization;

public class prev_jour : MonoBehaviour
{ 
    [SerializeField] GameObject[] _cards = new GameObject[4];

    public void back_card()
    {
        for (int i = _cards.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                break;
            }
            if (_cards[i].active == false)
            {

            }
            if (_cards[i].active == true)
            {
                _cards[i].SetActive(false);
                i--;
                _cards[i].SetActive(true);
                break;
            }
        }
    }

}