using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_vaccine : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Patient_info currentPatient;
    [SerializeField] private minigameCurrentPatient minigamePanel;

    //[SerializeField] private minigameCurrentPatient;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startMiniGame()
    {
        minigamePanel.currPatient = this.currentPatient;
        minigamePanel.startMinigame();
    }
    
    
    
}
