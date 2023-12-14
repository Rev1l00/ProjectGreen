using TMPro;
using UnityEngine;

public class UIElement : MonoBehaviour
{
    public TMP_Text text;

    public void UpdateContent(int number)
    {
        text.text = number.ToString();
    }
}
