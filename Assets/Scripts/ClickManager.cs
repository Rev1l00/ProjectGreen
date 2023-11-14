using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public static ClickManager instance;
    public bool placingLab;

    private void  Awake()
    {
        instance = this;   
    }
}
