using UnityEngine;
using TMPro;

public class canvasManager : MonoBehaviour
{
    public GameObject contButtons;
    public TMP_Text continentText;

    public string selectedCont = "None";

    public void disableContButtons()
    {
        contButtons.SetActive(false);
    }

    public void btn_pressed(string buttonName)
    {
        contButtons.SetActive(false);   // Disable the buttons
        selectedCont = buttonName;       // Set selectedCont to the name of the pressed button
        continentText.SetText(selectedCont);    // Set the continentText
        contButtons.SetActive(true);    // Enable the buttons
    }

}
