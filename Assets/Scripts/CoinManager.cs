using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public TMP_Text coinText;
    public int coinCount = 0;

    public void AddCoins()
    {
        coinCount += 10;
    }

    public void DeductCoins(int amount)
    {
        if (coinCount >= amount)
        {
            coinCount -= amount;
        }
        else
        {
            Debug.Log("Not enough coins to deduct.");
        }
    }

    public void Update()
    {
        coinText.SetText("Coins: " + coinCount);
    }
}
