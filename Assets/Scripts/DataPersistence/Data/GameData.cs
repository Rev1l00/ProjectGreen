using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int day;
    public int month;
    public int year;

    // The values defined in this constructor will be the default values
    // The game starts with when there's no data to load
    public GameData()
    {
        this.day = 1;
        this.month = 1;
        this.year = 2100;
    }
}
