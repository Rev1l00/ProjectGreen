using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private const int SecondsInDay = 1;
    private const int DaysInMonth = 30;
    private const int MonthsInYear = 12;

    public Button pauseButton;
    public Button playButton;
    public Button ffwButton;

    private int year = 2100;
    private int month = 1;
    private int day = 1;
    private float timer = 0f;
    private bool isPaused = true;

    public TMP_Text dateText;

    void Update()
    {
        if (!isPaused)
        {
            // Increase the timer by the time passed since the last frame
            timer += Time.deltaTime;

            // Check if one day has passed
            if (timer >= SecondsInDay)
            {
                // Update the day
                timer -= SecondsInDay;
                day++;

                // Check if the month needs to be updated
                if (day > DaysInMonth)
                {
                    day = 1;
                    month++;

                    // Check if the year needs to be updated
                    if (month > MonthsInYear)
                    {
                        month = 1;
                        year++;
                    }
                }

                // Update the text object to display the current date
                UpdateDateText();
            }
        }
    }

    // Helper method to update the text object with the current date
    private void UpdateDateText()
    {
        string formattedDay = day.ToString().PadLeft(2, '0');
        string formattedMonth = month.ToString().PadLeft(2, '0');
        dateText.text = string.Format("{0}/{1}/{2}", formattedDay, formattedMonth, year);
    }

    // Function to pause the time
    public void PauseTime()
    {
        isPaused = true;

        pauseButton.interactable = false;
        ffwButton.interactable = true;
        playButton.interactable = true;
    }

    // Function to normalize the time (set time back to 2100/01/01)
    public void UnpauseTime()
    {
        isPaused = false;
        Time.timeScale = 2f;

        pauseButton.interactable = true;
        playButton.interactable = false;
        ffwButton.interactable = true;
    }

    // Function to fast forward the time by 2x
    public void FastForwardTime()
    {
        isPaused = false;
        Time.timeScale = 4f;

        pauseButton.interactable = true;
        playButton.interactable = true;
        ffwButton.interactable = false;
    }
}
