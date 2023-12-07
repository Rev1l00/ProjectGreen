using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int coinCount;
    public float currentMonth;
    public float currentYear;

    // The values defined in this constructor will be the default values
    // The game starts with when there's no data to load.
    public GameData()
    {
        this.coinCount = 0;
        this.currentMonth = 1f;
        this.currentYear = 2100f;
    }
}
