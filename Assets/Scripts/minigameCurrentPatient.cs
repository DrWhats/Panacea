using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class minigameCurrentPatient : MonoBehaviour
{
    Dictionary<int, string> comp_dict = new Dictionary<int, string>
    {
        { 1, "Вода" },
        { 2, "Антисептик" },
        { 3, "Лимонная кислота" },
        { 4, "Куриное яйцо" },
        { 5, "Столовая сода" },
        { 6, "Крем для лица" },
        { 7, "Грязный платок" },
        { 8, "Шерсть орангутанга" },
        { 9, "Пробирка с воздухом" },
        { 10, "Глицин" },
        { 11, "Капли в нос" },
        { 12, "Компливит" },
    };

    [SerializeField] public Patient_info currPatient;
    [SerializeField] private current_vaccine currVaccine;
    [SerializeField] private Text info;
    [SerializeField] private Animator _animatorHand;
    [SerializeField] private Animator _animatorNeedle;

    [SerializeField] private GameObject Needle;
    [SerializeField] private GameObject Main_UI;
    [SerializeField] private Animator MiniGamePanel;
    [SerializeField] private SpriteRenderer manPicture;

    [SerializeField] Sprite[] femalePictures_needle = new Sprite[3];
    [SerializeField] Sprite[] malePictures_needle = new Sprite[3];

    [SerializeField] private Text scoreText;
    [SerializeField] private int score;

    public void startMinigame()
    {
        string name = currPatient._name.ToString();
        string age = currPatient._age.ToString();
        info.text = name + "," + age;
        score = 3;
        currPatient.setElementInfo(currVaccine.Elem_1, 0);
        currPatient.setElementInfo(currVaccine.Elem_2, 1);
        currPatient.setElementInfo(currVaccine.Elem_3, 2);
        currPatient.setElementInfo(currVaccine.Elem_4, 3);
        currPatient.setEff(-1);

        InvokeRepeating("changeSpeed", 2.0f, 2.0f);
        setPicture();
    }

    public void setPicture()
    {
        if (currPatient.sex)
        {
            manPicture.sprite = femalePictures_needle[currPatient.bez_rukava];
        }
        else
        {
            manPicture.sprite = malePictures_needle[currPatient.bez_rukava];
        }
    }

    public void stopNeedle()
    {
        _animatorHand.enabled = false;
        _animatorNeedle.Play("Needle_activate");
    }

    public void NeedleSuccess()
    {
        MiniGamePanel.Play("Desk_close");


        _animatorHand.enabled = true;

        _animatorNeedle.Play("Needle_deactivate");

        currPatient.Vaccinated();

        Main_UI.SetActive(true);

        currVaccine.resetElements();
        int effect = 0;
        foreach (var patient_comp in currPatient._elementsID)
        {
            foreach (var effective_comp in currVaccine._effectiveElements)
            {
                if (patient_comp == effective_comp)
                {
                    effect += 25;
                }
            }
        }

        currPatient.setEff(effect);
        currPatient.Mass_Prod_Finish(effect);
        currPatient.transformation(effect);
    }

    public void NeedleFail()
    {
        _animatorHand.enabled = true;
        _animatorNeedle.Play("Needle_deactivate");
        score--;

        if (score <= 0)
        {
            MiniGamePanel.Play("Desk_close");
            _animatorHand.enabled = true;
            _animatorNeedle.Play("Needle_deactivate");
            Main_UI.SetActive(true);
            currPatient.setEff(-2);
        }
        else
        {
            scoreText.text = score.ToString() + "/3";
        }
    }

    void changeSpeed()
    {
        _animatorHand.speed = Random.Range(0.5f, 2.0f);
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}