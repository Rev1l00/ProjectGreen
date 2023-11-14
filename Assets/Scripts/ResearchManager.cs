using TMPro;
using UnityEngine;

public class ResearchManager : MonoBehaviour
{
    public TMP_Text title;
    private string infoTitle;

    private void Start()
    {
        infoTitle = Clickable.instance.selectedCont;
        title.SetText(infoTitle);
    }
}
