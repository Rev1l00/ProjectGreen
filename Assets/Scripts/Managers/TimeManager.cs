using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [Header("Time Settings")]
    public float secondsPerMonth = 1.0f; // Change this value in the Unity Editor to control the speed of time passage
    public int startYear = 2023;

    [Header("UI Display")]
    public TextMeshProUGUI timeDisplay; // Reference to your TextMeshPro text object

    private float timePassed; // in seconds
    private int monthsPassed;
    private int yearsPassed;

    private void Update()
    {
        timePassed += Time.deltaTime;

        // Check if a month has passed
        if (timePassed >= secondsPerMonth)
        {
            timePassed -= secondsPerMonth;

            monthsPassed++;

            // Update the year at the start of each new year
            if (monthsPassed % 12 == 0)
            {
                yearsPassed++;

                // Check if a year has passed
                if (yearsPassed == 100)
                {
                    Debug.Log("100 years have passed. Game over!");
                    // Add any additional logic you want to execute after 100 years
                }
            }

            // Update the TextMeshPro text object
            UpdateTimeDisplay();
        }
    }

    private void UpdateTimeDisplay()
    {
        // Calculate the current month and year for display
        int currentMonth = (monthsPassed % 12 == 0) ? 12 : monthsPassed % 12;
        int currentYear = startYear + monthsPassed / 12;

        // Add leading zero to the month if necessary
        string monthString = (currentMonth < 10) ? $"0{currentMonth}" : currentMonth.ToString();

        // Combine the month and year for display
        string timeString = $"{monthString}/{currentYear}";

        // Check if the TextMeshPro text object is assigned
        if (timeDisplay != null)
        {
            // Update the text
            timeDisplay.text = timeString;
        }
        else
        {
            // Log a warning if the TextMeshPro text object is not assigned
            Debug.LogWarning("TextMeshPro text object not assigned to TimeTracker script.");
        }
    }
}
