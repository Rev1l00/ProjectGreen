using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class canvasManager : MonoBehaviour
{
    public TMP_Text continentText;
    public TMP_Text researchContinentText;
    public Button researchButton;

    public string selectedCont = "None";
    
    public void Start()
    {
        researchButton.interactable = false;
    }

    public void Btn_pressed(string buttonName)
    {
        selectedCont = buttonName;       // Set selectedCont to the name of the pressed button
        continentText.SetText(selectedCont);    // Set the continentText
        researchContinentText.SetText(selectedCont);
        researchButton.interactable = true;
    }

    public void OceanPressed()
    {
        researchButton.interactable = false;
        selectedCont = "World";
        continentText.SetText(selectedCont);
    }
}
