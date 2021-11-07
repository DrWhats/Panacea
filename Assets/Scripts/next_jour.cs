using System;
using UnityEngine;

public class next_jour : MonoBehaviour
{
    [SerializeField] GameObject[] _Cards = new GameObject[4];


    private void Start()
    {
        for (int i = 1; i < _Cards.Length;i++)
        {
            _Cards[i].SetActive(false);
        }
    }
    

    public void next_card()
    {
        for (int i = 0; i < _Cards.Length - 1; i++)
        {
            if (i == _Cards.Length - 1)
            {
                break;
            }
            if (_Cards[i].active == false)
            {

            }
            if (_Cards[i].active == true)
            {
                _Cards[i].SetActive(false);
                i++;
                _Cards[i].SetActive(true);
                break;
            }
        }
    }

}