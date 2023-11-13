using UnityEngine;
using TMPro;

public class ButtonUI : MonoBehaviour
{
    public TMP_Text yearCounter;
    public int year = 2023;

    public void AdvanceYearButton() 
    {
        year++;
    }

    public void Update()
    {
        yearCounter.SetText(""+ year);
    }
}
