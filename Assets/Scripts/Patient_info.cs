using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
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
    [SerializeField] public int _efficiency; //Показатель эффективности вакцины
    [SerializeField] private Text _patientEfficiency;
    [SerializeField] public bool sex; //true - female, false - male

    [SerializeField] public int[] _elementsID = new int[4];
    public string Element_first;
    public string Element_second;
    public string Element_third;
    public string Element_fourth;
    [SerializeField] private Text first_GameObjects;
    [SerializeField] private Text second_GameObjects;
    [SerializeField] private Text third_GameObjects;
    [SerializeField] private Text fourth_GameObjects;
    [SerializeField] private GameObject test_vaccine;
    [SerializeField] private GameObject mass_prod;
    [SerializeField] private toDefault _toDefault;

    [SerializeField] private SpriteRenderer picture;
    public Sprite[] femalePictures = new Sprite[4];
    public Sprite[] malePictures = new Sprite[4];
    public Sprite[] transformationPictures = new Sprite[4];


    [SerializeField] public int bez_rukava;

    private string[] _patientNamesFemale =
        { "Диана", "Екатерина", "Полина", "Алиса", "Ксения", "Марина", "Мария", "Кира", "Ирина", "Вероника" };

    private string[] _patientNamesMale =
        { "Василий", "Петр", "Кирилл", "Данил", "Олег", "Лев", "Руслан", "Юрий", "Анатолий", "Константин" };

    Dictionary<int, string> comp_dict = new Dictionary<int, string>
    {
        { 1, "Вода" },
        { 2, "Антисептик" },
        { 3, "Лимонная кислота" },
        { 4, "Куриные яйца" },
        { 5, "Столовая сода" },
        { 6, "Крем для лица" },
        { 7, "Пробирка со слизью" },
        { 8, "Шерсть орангутанга" },
        { 9, "Пробирка с воздухом" },
        { 10, "Глицин" },
        { 11, "Капли в нос" },
        { 12, "Детские таблетки" },
    };


    // Стартуем и ставим ,что нет данных
    void Start()
    {
        if (_elementsID[0] != 0)
        {
            Element_first = comp_dict[_elementsID[0]];
            first_GameObjects.text = Element_first;
        }
        else first_GameObjects.text = "Нет данных";

        if (_elementsID[1] != 0)
        {
            Element_second = comp_dict[_elementsID[1]];
            second_GameObjects.text = Element_second;
        }
        else second_GameObjects.text = "Нет данных";

        if (_elementsID[2] != 0)
        {
            Element_third = comp_dict[_elementsID[2]];
            third_GameObjects.text = Element_third;
        }
        else third_GameObjects.text = "Нет данных";

        if (_elementsID[3] != 0)
        {
            Element_fourth = comp_dict[_elementsID[3]];
            fourth_GameObjects.text = Element_fourth;
        }
        else fourth_GameObjects.text = "Нет данных";

        if (_patientID != 1)
        {
            this.gameObject.SetActive(false);
        }




        setAge(Random.Range(20, 30).ToString());
        setSex();
        Debug.Log(sex);

        if (sex == true)
        {
            setName(_patientNamesFemale[Random.Range(0, _patientNamesFemale.Length)]);

        }
        else if (sex == false)
        {
            setName(_patientNamesMale[Random.Range(0, _patientNamesMale.Length)]);

        }

        setPicture();
    }

    // Update is called once per frame
    void Update()
    {
    }

    //Устанавливаем ID элемента из словаря в один из четырех элементов вакцины (от 0 до 3)
    public void setElementInfo(int setElement, int toPosition)
    {
        _elementsID[toPosition] = setElement;

        if (_elementsID[0] != 0)
        {
            Element_first = comp_dict[_elementsID[0]];
            first_GameObjects.text = Element_first;
        }
        else first_GameObjects.text = "Нет данных";

        if (_elementsID[1] != 0)
        {
            Element_second = comp_dict[_elementsID[1]];
            second_GameObjects.text = Element_second;
        }
        else second_GameObjects.text = "Нет данных";

        if (_elementsID[2] != 0)
        {
            Element_third = comp_dict[_elementsID[2]];
            third_GameObjects.text = Element_third;
        }
        else third_GameObjects.text = "Нет данных";

        if (_elementsID[3] != 0)
        {
            Element_fourth = comp_dict[_elementsID[3]];
            fourth_GameObjects.text = Element_fourth;
        }
        else fourth_GameObjects.text = "Нет данных";
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

    public void setPicture()
    {
        if (sex)
        {
            int sprite_id = Random.Range(0, femalePictures.Length - 1);
            picture.sprite = femalePictures[sprite_id];
            bez_rukava = sprite_id;
        }
        else
        {
            int sprite_id = Random.Range(0, malePictures.Length - 1);
            picture.sprite = malePictures[sprite_id];
            bez_rukava = sprite_id;
        }
    }

    public void setSex()
    {
        sex = randomBoolean();
    }

    public void setEff(int efficiency)
    {
        _efficiency = efficiency;
        Debug.Log(efficiency);
        switch (_efficiency)
        {
            case -1:
            {
                string s = "Не испытано";
                _patientEfficiency.text = s;
                Debug.Log("MINUS-3");
                break;
            }

            case -2:
            {
                Debug.Log("MINUS-4");
                string s = "Пациент сбежал!";
                _patientEfficiency.text = s;
                Vaccinated();
                break;
            }

            default:
            {
                Debug.Log("MINUS-5");
                Vaccinated();
                _patientEfficiency.text = _efficiency.ToString() + "%";
                break;
            }
        }
    }

    public void Mass_Prod_Finish(int efficiency)
    {
        if (efficiency == 100)
        {
            mass_prod.SetActive(true);
        }
    }

    public void transformation(int efficiency)
    {
        if (efficiency < 100 && efficiency >= 0)
        {
            int trans_id = Random.Range(0, transformationPictures.Length - 1);
            picture.sprite = transformationPictures[trans_id];
        }
    }


    bool randomBoolean()
    {
        return (Random.value > 0.5f);
    }
}