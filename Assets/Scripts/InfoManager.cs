using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoManager : MonoBehaviour
{
    // Definerer variabler som blir brukt til og hente tittelen
    public TMP_Text title;
    private string infoTitle = "None";

    // Definerer tekst ovjektene for alle kontinent verdiene
    public TMP_Text popValue;
    public TMP_Text incomeValue;
    public TMP_Text tempValue;
    public TMP_Text stationsValue;

    // Definerer variabler for alle kontinent verdiene
    private string population;
    private string income;
    private string averageTemp;
    private string researchStations;

    // Definerer lister som skal inneholde alle verdiene for vert kontinent
    List<int> North_America = new List<int>{378904407, 0, 11, 0};
    List<int> South_America = new List<int>{378904407, 0, 30, 0};
    List<int> Europe = new List<int>{378904407, 0, 11, 0};
    List<int> Asia = new List<int>{378904407, 0, 11, 0};
    List<int> Africa = new List<int>{378904407, 0, 11, 0};
    List<int> Oceania = new List<int>{378904407, 0, 11, 0};

    void Start()
    {
        // Henter og setter tittelen/navnet på kontinentet som spilleren vill se info om fra scriptet "Clickable"
        infoTitle = Clickable.instance.selectedCont;
        title.SetText(infoTitle);

        // Kjører funksjonen som skal hente verdiene basert på kontinentet
        GetValues(North_America);

        // Setter at alle tekst objektene skal være riktig verdi
        popValue.SetText(population);
        incomeValue.SetText(income + "$");
        tempValue.SetText(averageTemp + "°");
        stationsValue.SetText(researchStations);
    }

    private void GetValues(List<int> continent)
    {
        // Henter verdiene fra en liste som har verdiene til ett kontinent
        population = continent[0].ToString();
        income = continent[1].ToString();
        averageTemp = continent[2].ToString();
        researchStations = continent[3].ToString();
    }
}
