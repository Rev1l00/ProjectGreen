using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{
    public float alphaThreshold = 0.1f;
    public SquarePlacement squarePlacement; // Reference to the SquarePlacement script.

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;

        squarePlacement = GameObject.Find("SquarePlacementController").GetComponent<SquarePlacement>();
    }

    public void buttn_pressed()
    {
        if (squarePlacement.inPlacementMode == false)
        {
            Debug.Log(this + " was pressed!");
            // Add any other functionality you want to perform when clicking.
        }
    }
}
