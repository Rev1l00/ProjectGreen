using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float resetTime = 13f; // Set the time to reset the timer in seconds
    private float currentTime;
    private float yearCount = 2022f;
    public TextMeshProUGUI timerText; // Reference to a TextMeshProUGUI component to display the timer

    private bool isPaused = true; // Flag to track whether the timer is paused

    void Start()
    {
        ResetTimer();
    }

    void Update()
    {
        // Update the timer if not paused
        if (!isPaused)
        {
            currentTime += Time.deltaTime;
            UpdateTimerDisplay();

            // Reset the timer if it reaches the specified reset time
            if (currentTime >= resetTime)
            {
                ResetTimer();
            }
        }
    }

    void UpdateTimerDisplay()
    {
        // Update the TextMeshProUGUI component with yearCount and seconds
        timerText.text = string.Format("{1:0}/{0:0}", yearCount, Mathf.FloorToInt(currentTime));
    }

    void ResetTimer()
    {
        // Reset the timer to zero and increase the yearCount
        currentTime = 1f;
        yearCount++;
    }

     // Function to speed up the time
    public void SpeedUpTime(float factor)
    {
        isPaused = false;
        Time.timeScale = factor;
    }

    // Function to pause the timer
    public void PauseTime()
    {
        isPaused = true;
        Time.timeScale = 0f; // Set timeScale to 0 for pause
    }

    // Function to normalize the time and unpause
    public void NormalizeTime()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }
}
