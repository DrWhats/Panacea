using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class main_dialogue : MonoBehaviour
{

    [SerializeField] private Text main_text;
    [SerializeField] private string[] phrases;
    private int currentText = 0;
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

        if (currentText == phrases.Length)
        {
            button_next.SetActive(false);
            button_continue.SetActive(true);
        }
        
    }
    
}
