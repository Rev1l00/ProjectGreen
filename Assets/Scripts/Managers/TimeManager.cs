using Unity.VisualScripting;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static int currentYear = 2023;
    public static int monthsPerYear = 12;
    public static int gameDurationInYears = 100;

    public float timeScale = 1f;

    private float timePassed;
    private float monthDuration = 1f;

    private void Update()
    {
        timePassed += Time.deltaTime;
        Debug.Log(timePassed);

        if (timePassed >= monthDuration)
        {
            timePassed -= monthDuration;
            AdvanceTime();
        }

        if (currentYear - 2023 >= gameDurationInYears)
        {
            EndGame();
        }

        Time.timeScale = timeScale;
    }

    private void AdvanceTime()
    {
        int monthsPassed = Mathf.FloorToInt(timePassed / monthDuration);
        // Debug.Log(monthsPassed);
        timePassed -= monthsPassed * monthDuration;

        // Update the current year
        currentYear += monthsPassed / monthsPerYear;

        // Update the current month
        int currentMonth = Mathf.FloorToInt((currentYear - 2023) * monthsPerYear) + 1;

        // Print the current year and month for debugging
        Debug.Log("Current Year: " + currentYear + " Month: " + currentMonth);
    }

    private void EndGame()
    {
        Debug.Log("Game Over! 100 years have passed");
    }
}
