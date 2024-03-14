using UnityEngine;
using TMPro;

public class CO2Simulator : MonoBehaviour
{
    public float initialCO2Percentage = 600f; // Initial CO2 percentage
    public float dailyCO2IncreasePercentage = 1.1f; // Daily increase percentage

    public float currentCO2Percentage; // Current CO2 percentage

    public TMP_Text co2Text; // Reference to the TMP text object to display CO2 percentage

    void Start()
    {
        currentCO2Percentage = initialCO2Percentage;
        UpdateCO2Text();
    }

    // Function to simulate CO2 increase for a given number of days
    public void SimulateCO2Increase(int numberOfDays)
    {
        // Simulate CO2 increase for the given number of days
        for (int i = 0; i < numberOfDays; i++)
        {
            currentCO2Percentage *= dailyCO2IncreasePercentage;
        }

        // Update TMP text object
        UpdateCO2Text();
    }

    void UpdateCO2Text()
    {
        // Update the TMP text object to display the current CO2 percentage
        co2Text.text = string.Format("CO2%: {0:F1}", currentCO2Percentage);
    }
}
