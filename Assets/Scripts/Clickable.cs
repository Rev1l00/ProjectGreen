using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{
    public Image panelImage;
    public float alphaThreshold = 0.1f;
    public SquarePlacement squarePlacement; // Reference to the SquarePlacement script.

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;
        squarePlacement = GameObject.Find("SquarePlacementController").GetComponent<SquarePlacement>();
    
        panelImage = GameObject.Find("ContInf").GetComponentInChildren<Image>();
            if (panelImage != null)
            {
                panelImage.enabled = false; // Ensure the image is initially hidden
            }
            else
            {
                Debug.LogError("Image component not found in the parent GameObject. Make sure it exists.");
            }
    }

    public void buttn_pressed()
    {
        if (squarePlacement.inPlacementMode == false)
        {
            Debug.Log(this + " was pressed!");

            panelImage.enabled = !panelImage.enabled;
            // Add any other functionality you want to perform when clicking.
        }
    }
}
