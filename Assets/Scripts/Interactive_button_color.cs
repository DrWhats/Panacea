using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Interactive_button_color : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject button;
    public Color Col = new Color(0, 0, 0, 1);
    public Text TheText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        var but = button.GetComponent<Button>();
        if (but.interactable) TheText.color = Color.white; //Or however you do your color
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        var but = button.GetComponent<Button>();
        if (but.interactable) TheText.color = Col; //Or however you do your color
    }
}