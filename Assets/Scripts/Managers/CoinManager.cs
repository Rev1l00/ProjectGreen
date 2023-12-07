using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour, IDataPersistence
{
    public int coinCount = 0;
    public TMP_Text coinText;

    public void LoadData(GameData data)
    {
        this.coinCount = data.coinCount;
    }

    public void SaveData(ref GameData data)
    {
        data.coinCount = this.coinCount;
    }

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
        coinText.SetText(""+ coinCount);
    }
}
