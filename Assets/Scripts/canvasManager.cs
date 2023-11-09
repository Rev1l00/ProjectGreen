using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasManager : MonoBehaviour
{
    public GameObject contButtons;

    public void disableContButtons()
    {
        contButtons.SetActive(false);
        Debug.Log("Pressed");
    }
}
