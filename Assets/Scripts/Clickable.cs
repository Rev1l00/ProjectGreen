using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clickable : MonoBehaviour
{
    // Definerer en variabel som lagrer hvilket kontinent brukeren skal se info om og
    public float alphaThreshold = 0.1f;

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;
    }
}
