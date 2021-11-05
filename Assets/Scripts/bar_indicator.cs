using UnityEditor;
using UnityEngine;

public class bar_indicator : MonoBehaviour
{
    [SerializeField] private GameObject[] bar_mass = new GameObject[5];

    void Start()
    {
        bar_selector();
        bar_mass[0].SetActive(true);
    }

    public void bar_selector()
    {
        foreach (var bar in bar_mass)
        {
            bar.SetActive(false);
        }
    }

    public void bar_1()
    {
        bar_selector();
        bar_mass[1].SetActive(true);
    }
    public void bar_2()
    {
        bar_selector();
        bar_mass[2].SetActive(true);
    }
    public void bar_3()
    {
        bar_selector();
        bar_mass[3].SetActive(true);
    }
    public void bar_4()
    {
        bar_selector();
        bar_mass[4].SetActive(true);
    }
}