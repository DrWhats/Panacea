using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    [SerializeField] private Patient_info[] patinf;
    [SerializeField] private GameObject button_restart;
    public bool all_vac;

    void Start()
    {
        
    }

    public void check_restart()
    {
        if (all_vac == false)
        {
            int i = 0;
            foreach (var vac in patinf)
            {
                if (vac._vaccinated)
                {
                    i++;
                }
            }

            if (i == patinf.Length)
            {
                all_vac = true;
                button_restart.SetActive(true);
            }
        }
    }
    public void restart_game()
    {
        SceneManager.LoadScene(0);
    }
}
