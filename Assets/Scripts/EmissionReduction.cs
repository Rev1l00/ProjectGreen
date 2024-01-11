using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EmissionReduction : MonoBehaviour
{
    public float emissionReductionRate = 0.1f; // Adjust as needed
    public TMP_Text emissionText; // Reference to UI text displaying emission reduction

    private void Start()
    {
        emissionText.text = "0%"; // Initialize UI text
    }

    public void ApplyEmissionReduction_RenewableEnergy()
    {
        Debug.Log("Clicked!");
        // Apply emission reduction logic for Renewable Energy project
        ReduceContinentEmissions(0.05f); // Example: Reduce emissions by 5%
        UpdateEmissionText();
    }

    public void ApplyEmissionReduction_Afforestation()
    {
        // Apply emission reduction logic for Afforestation project
        ReduceContinentEmissions(0.08f); // Example: Reduce emissions by 8%
        UpdateEmissionText();
    }

    public void ApplyEmissionReduction_GreenTransportation()
    {
        // Apply emission reduction logic for Green Transportation project
        ReduceContinentEmissions(0.07f); // Example: Reduce emissions by 7%
        UpdateEmissionText();
    }

    public void ApplyEmissionReduction_EnergyEfficiency()
    {
        // Apply emission reduction logic for Energy Efficiency project
        ReduceContinentEmissions(0.06f); // Example: Reduce emissions by 6%
        UpdateEmissionText();
    }

    void ReduceContinentEmissions(float reductionPercentage)
    {
        // Add logic to reduce emissions on the selected continent
        // You can use PlayerPrefs, a GameManager, or other methods to store and track data
        // Example: Reduce emissions on the continent by the specified percentage
        float currentEmissions = PlayerPrefs.GetFloat("ContinentEmissions", 1.0f); // Default emissions set to 1.0 (100%)
        currentEmissions *= (1.0f - reductionPercentage);
        PlayerPrefs.SetFloat("ContinentEmissions", currentEmissions);
    }

    void UpdateEmissionText()
    {
        // Update UI text to display current emission reduction
        emissionText.text = CalculateTotalEmissionReduction() + "%";
    }

    float CalculateTotalEmissionReduction()
    {
        // Add logic to calculate and return the total emission reduction percentage
        // This could involve aggregating reduction values from different continents
        return 0.0f; // Placeholder value
    }
}
