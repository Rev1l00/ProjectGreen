using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Clickable : MonoBehaviour
{
    public static Clickable instance;

    public GameObject contButtons;
    public TMP_Text continentText;
    public SquarePlacement squarePlacement;

    public float alphaThreshold = 0.1f;
    public string selectedCont = "None";

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;
        squarePlacement = GameObject.Find("SquarePlacementController").GetComponent<SquarePlacement>();
    }

    public void btn_pressed()
    {
        selectedCont = this.name;
        contButtons.SetActive(false);
        if (squarePlacement.inPlacementMode == false)
        {
            Debug.Log(selectedCont + " was pressed!");
            continentText.SetText(selectedCont);
            contButtons.SetActive(true);
        }
    }

    public void info_btn()
    {
        selectedCont = continentText.text;
        Debug.Log(selectedCont);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
