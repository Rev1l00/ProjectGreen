using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoManager : MonoBehaviour
{
    public TMP_Text title;
    private string infoTitle = "None";

    public TMP_Text popValue;
    public TMP_Text IncomeValue;
    public TMP_Text tempValue;
    public TMP_Text stationsValue;

    public string population;
    public string income;
    public string averageTemp;
    public string researchStations;

    void Start()
    {
        infoTitle = Clickable.instance.selectedCont;
        title.SetText(infoTitle);
        GetValues();
    }

    private void GetValues()
    {
        Debug.Log("Getting Values");
    }
}
