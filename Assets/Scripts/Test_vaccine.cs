
using UnityEngine;

public class Test_vaccine : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Patient_info currentPatient;
    [SerializeField] private minigameCurrentPatient minigamePanel;
    [SerializeField] private current_vaccine currVaccine;
    [SerializeField] private GameObject main_ui;
    [SerializeField] private Animator anim;

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
        if (currVaccine.check_vac() == true)
        {
            minigamePanel.currPatient = this.currentPatient;
            minigamePanel.startMinigame();

            main_ui.SetActive(false);
            anim.Play("Desk_show");
        }
    }
    
    
    
}
