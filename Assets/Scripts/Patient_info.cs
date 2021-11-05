using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Patient_info : MonoBehaviour
{
    [SerializeField] private int _patientID; //Номер пациента от 1 до 10
    [SerializeField] public string _name; //Имя
    [SerializeField] private Text _patientName;
    [SerializeField] public string _age; //Возраст
    [SerializeField] private Text _patientAge;
    [SerializeField] private bool _vaccinated; //Галочка "вакциниррван" или нет
    [SerializeField] private int _efficiency; //Показатель эффективности вакцины
    [SerializeField] private Text _patientEfficiency;

    
    [SerializeField] private int[] _elementsID = new int[4];
    public string Element_first;
    public string Element_second;
    public string Element_third;
    public string Element_fourth;
    [SerializeField] private Text first_GameObjects;
    [SerializeField] private Text second_GameObjects;
    [SerializeField] private Text third_GameObjects;
    [SerializeField] private Text fourth_GameObjects;

    [SerializeField] private GameObject test_vaccine;
    [SerializeField] private toDefault _toDefault;
   
    
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
    

    // Стартуем и ставим ,что нет данных
    void Start()
    {
        if (_elementsID[0] != 0)
        {
            Element_first = comp_dict[_elementsID[0]];
            first_GameObjects.text = Element_first;
        } else first_GameObjects.text = "Нет данных";
        
        if (_elementsID[1] != 0)
        {
            Element_second = comp_dict[_elementsID[1]];
            second_GameObjects.text = Element_second;
        } else second_GameObjects.text = "Нет данных";
        
        if (_elementsID[2] != 0)
        {
            Element_third = comp_dict[_elementsID[2]];
            third_GameObjects.text = Element_third;
        } else third_GameObjects.text = "Нет данных";
        
        if (_elementsID[3] != 0)
        {
            Element_fourth = comp_dict[_elementsID[3]];
            fourth_GameObjects.text = Element_fourth;
        } else fourth_GameObjects.text = "Нет данных";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Устанавливаем ID элемента из словаря в один из четырех элементов вакцины (от 0 до 3)
    public void setElementInfo(int setElement, int toPosition)
    {
        _elementsID[toPosition] = setElement;
        Debug.Log("PEE PEE POO POO CHEEEECK");
        
        if (_elementsID[0] != 0)
        {
            Element_first = comp_dict[_elementsID[0]];
            first_GameObjects.text = Element_first;
        } else first_GameObjects.text = "Нет данных";
        
        if (_elementsID[1] != 0)
        {
            Element_second = comp_dict[_elementsID[1]];
            second_GameObjects.text = Element_second;
        } else second_GameObjects.text = "Нет данных";
        
        if (_elementsID[2] != 0)
        {
            Element_third = comp_dict[_elementsID[2]];
            third_GameObjects.text = Element_third;
        } else third_GameObjects.text = "Нет данных";
        
        if (_elementsID[3] != 0)
        {
            Element_fourth = comp_dict[_elementsID[3]];
            fourth_GameObjects.text = Element_fourth;
        } else fourth_GameObjects.text = "Нет данных";
        


    }

     public void setName(string Name)
    {
        _name = Name;
        _patientName.text = Name;
    }
    
    public void setAge(string Age)
    {
        _age = Age;
        _patientAge.text = Age;
    }

    public void Vaccinated()
    {
        test_vaccine.SetActive(false);
        _vaccinated = true;
        _toDefault.ResetElements();
        
    }

    public void setEff(int efficiency)
    {
        if (efficiency == -1)
        {
            _patientEfficiency.text = "НЕ ИСПЫТАНО";
        }
        else
        {
            _efficiency = efficiency;
            _patientEfficiency.text = _efficiency.ToString() + "%";
        }
        
    }
}
