using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

    [SerializeField] public Patient_info currPatient;
    [SerializeField] private current_vaccine currVaccine;
    [SerializeField] private Text info;
    [SerializeField] private Animator _animatorHand;
    [SerializeField] private Animator _animatorNeedle;
    
    [SerializeField] private GameObject Needle;
    [SerializeField] private GameObject Main_UI;
    [SerializeField] private Animator MiniGamePanel;

    public void startMinigame()
    {
        string name = currPatient._name.ToString();
        string age = currPatient._age.ToString();
        info.text =  name + "," + age;
        currPatient.setElementInfo(currVaccine.Elem_1,0);
        currPatient.setElementInfo(currVaccine.Elem_2,1);
        currPatient.setElementInfo(currVaccine.Elem_3,2);
        currPatient.setElementInfo(currVaccine.Elem_4,3);
        currPatient.setEff(-1);

        InvokeRepeating("changeSpeed",2.0f,2.0f);
       


    }

    public void stopNeedle()
    {
        _animatorHand.enabled = false;
        _animatorNeedle.Play("Needle_activate");
        
    }

    public void NeedleSuccess()
    {
        MiniGamePanel.Play("Desk_close");
        Debug.Log("1");
            
        _animatorHand.enabled = true;
        Debug.Log("2");
        _animatorNeedle.Play("Needle_deactivate");
        Debug.Log("3");
        currPatient.Vaccinated();
        Debug.Log("4");
        Main_UI.SetActive(true);
        Debug.Log("5");
        
        currVaccine.resetElements();
    }

    public void NeedleFail()
    {
        _animatorHand.enabled = true;
        _animatorNeedle.Play("Needle_deactivate");
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