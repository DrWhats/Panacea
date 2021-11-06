using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class prologue : MonoBehaviour
{

    [SerializeField] private Text main_text;
    [SerializeField] private string[] phrases;
    [SerializeField] private Animator Bus;
    public GameObject Character;
    private int currentText = 0;
    public bool busStopped = false;
    [SerializeField] private GameObject button_continue;
    [SerializeField] private GameObject button_next;
    
    
    void Start()
    {
        main_text.text = phrases[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextText()
    {
        currentText++;
        if (currentText < phrases.Length)
        {
            main_text.text = phrases[currentText];
        }
        

        if (busStopped)
        {
            Bus.Play("Bus_move_2");
            Character.SetActive(false);
            
            button_next.SetActive(false);
            button_continue.SetActive(true);
            
        }

        if (currentText == phrases.Length - 1)
        {
            Bus.Play("Bus_move_1");
            busStopped = true;

        }
        
        if (currentText == 1)
        {
            Character.GetComponent<Animator>().Play("chel_smoke");
            

        }
    }

    public void NextPart()
    {
        SceneManager.LoadScene(2);
    }
}
