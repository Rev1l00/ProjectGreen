using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public void EU_button()
    {
        Debug.Log("Europe Pressed");
    }

    public void AF_button()
    {
        Debug.Log("Africa Pressed");
    }

    public void AS_button()
    {
        Debug.Log("Asia Pressed");
    }

    public void NA_button()
    {
        Debug.Log("North America Pressed");
    }

    public void SA_button()
    {
        Debug.Log("South America Pressed");
    }

    public void AU_button()
    {
        Debug.Log("Australia Pressed");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Button clicked!");
    }

}
