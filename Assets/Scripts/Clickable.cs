using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clickable : MonoBehaviour
{
    public GameObject contButtons;
    public TMP_Text continentText;
    public SquarePlacement squarePlacement;
    public float alphaThreshold = 0.1f;

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;
        squarePlacement = GameObject.Find("SquarePlacementController").GetComponent<SquarePlacement>();
    }

    public void buttn_pressed()
    {
        contButtons.SetActive(false);
        if (squarePlacement.inPlacementMode == false)
        {
            Debug.Log(this + " was pressed!");
            continentText.SetText(this.name);
            contButtons.SetActive(true);
        }
    }
}
