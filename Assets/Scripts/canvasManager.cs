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

    public ResearchManager researchManager;

    public void Start()
    {
        researchButton.interactable = false;
    }

    public void BtnPressed(string buttonName)
    {
        selectedCont = buttonName;
        continentText.SetText(selectedCont);
        researchContinentText.SetText(selectedCont);
        researchButton.interactable = true;
    }

    public void OpenResearchMenu()
    {
        researchManager.AddResearchStation(selectedCont);
    }
}
