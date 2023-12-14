using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour, IDataPersistence
{
    public float resetTime = 13f; // Set the time to reset the timer in seconds
    private float currentMonth;
    private float currentYear;
    public TextMeshProUGUI timerText; // Reference to a TextMeshProUGUI component to display the timer

    public Button playBtn;
    public Button pauseBtn;
    public Button fastForwardBtn;

    private bool isPaused = true; // Flag to track whether the timer is paused

    void Start()
    {
        UpdateTimerDisplay();
    }

    void Update()
    {
        // Update the timer if not paused
        if (!isPaused)
        {
            currentMonth += Time.deltaTime;
            UpdateTimerDisplay();

            // Reset the timer if it reaches the specified reset time
            if (currentMonth >= resetTime)
            {
                ResetTimer();
            }
        }
    }

    void UpdateTimerDisplay()
    {
        // Update the TextMeshProUGUI component with yearCount and seconds
        if (!isPaused && Time.timeScale > 1)
        {
            timerText.text = string.Format("{1:D2}/{0:0}" + "  x" + Time.timeScale, currentYear, Mathf.FloorToInt(currentMonth));
        }
        else
        {
            timerText.text = string.Format("{1:D2}/{0:0}", currentYear, Mathf.FloorToInt(currentMonth));
        }

    }

    void ResetTimer()
    {
        // Reset the timer to zero and increase the yearCount
        currentMonth = 1f;
        currentYear++;
    }

     // Function to speed up the time
    public void SpeedUpTime(float factor)
    {
        isPaused = false;
        Time.timeScale = factor;
        EnableButtons();
        fastForwardBtn.interactable = false;
    }

    // Function to pause the timer
    public void PauseTime()
    {
        isPaused = true;
        Time.timeScale = 0f; // Set timeScale to 0 for pause
        EnableButtons();
        pauseBtn.interactable = false;
    }

    // Function to normalize the time and unpause
    public void NormalizeTime()
    {
        isPaused = false;
        Time.timeScale = 1f;
        EnableButtons();
        playBtn.interactable = false;
    }

    public void LoadData(GameData data)
    {
        this.currentMonth = data.currentMonth;
        this.currentYear = data.currentYear;
    }

    public void SaveData(ref GameData data)
    {
        data.currentMonth = this.currentMonth;
        data.currentYear = this.currentYear;
    }

    public void EnableButtons()
    {
        playBtn.interactable = true;
        pauseBtn.interactable = true;
        fastForwardBtn.interactable = true;
    }
}
