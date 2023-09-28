using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAButton : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<SouthAmerica>().alphaHitTestMinimumThreshold = 0.1f;
    }
}
