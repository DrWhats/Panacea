using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minigameCurrentPatient : MonoBehaviour
{
    
    Dictionary<int, string> comp_dict = new Dictionary<int, string>
    {
        {  1 ,"Вода"},
        {  2 ,"Антисептик"},
        {  3 ,"Лимонная кислота"},
        {  4 ,"Куриное яйцо"},
        {  5 ,"Столовая сода"},
        {  6 ,"Крем для лица"},
        {  7 ,"Грязный платок"},
        {  8 ,"Шерсть орангутанга"},
        {  9 ,"Пробирка с воздухом"},
        {  10 ,"Глицин"},
        {  11 ,"Капли в нос"},
        {  12 ,"Компливит"},
    };

    private Dictionary<int, bool> used_comp = new Dictionary<int, bool>
    {
        {  1 , false},
        {  2 , false},
        {  3 , false},
        {  4 , false},
        {  5 , false},
        {  6 , false},
        {  7 , false},
        {  8 , false},
        {  9 , false},
        {  10 , false},
        {  11 , false},
        {  12 , false},
    };

    [SerializeField] public Patient_info currPatient;
    [SerializeField] private Text info;

    public void startMinigame()
    {
        string name = currPatient._name.ToString();
        string age = currPatient._age.ToString();
        info.text =  name + "," + age;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
