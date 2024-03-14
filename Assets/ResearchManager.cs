using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResearchManager : MonoBehaviour
{
    // Dictionary to store research stations for each continent
    private Dictionary<string, List<string>> researchStations = new Dictionary<string, List<string>>();

    public TMP_Text researchStationText;

    // Add research station for the selected continent
    public void AddResearchStation(string continent)
    {
        if (!researchStations.ContainsKey(continent))
        {
            researchStations.Add(continent, new List<string>());
        }

        int stationCount = researchStations[continent].Count + 1;
        string stationName = "Station #" + stationCount;

        researchStations[continent].Add(stationName);

        UpdateResearchStationText(continent);
    }

    // Update the text object with the list of research stations for the selected continent
    private void UpdateResearchStationText(string continent)
    {
        if (researchStationText != null)
        {
            if (researchStations.ContainsKey(continent))
            {
                string text = "Research Stations for " + continent + ":\n";
                foreach (string station in researchStations[continent])
                {
                    text += station + "\n";
                }
                researchStationText.text = text;
            }
            else
            {
                researchStationText.text = "No research stations for " + continent;
            }
        }
    }
}
