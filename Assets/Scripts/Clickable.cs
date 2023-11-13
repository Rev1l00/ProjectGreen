using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Clickable : MonoBehaviour
{
    public static Clickable instance;

    // Definerer alle objektene som skal brukes i koden
    public GameObject contButtons;
    public TMP_Text continentText;

    // Definerer en variabel som lagrer hvilket kontinent brukeren skal se info om og
    public string selectedCont = "None";
    public float alphaThreshold = 0.1f;
    public bool placingLab;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        placingLab = SquarePlacement.instance.canPlace;
    }

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;
        selectedCont = this.name;   // Lagrer kontinentet brukeren vill se info om 
    }

    public void btn_pressed()
    {
        Debug.Log(SquarePlacement.instance.canPlace); // Tester om det funker
        contButtons.SetActive(false);   // Setter at info knappene skal være deaktivert fra start

        if (placingLab == false)
        {
            Debug.Log(selectedCont + " was pressed!");  // Tester om det funker
            continentText.SetText(selectedCont);    // Setter navnet på kontinentet over knappene sånn at spilleren vet hvilket kontinent som har blitt trykket på
            contButtons.SetActive(true);    // Aktiverer info knappene
        }
    }

    // Lagrer navnet på kontinentet som skal brukes på info siden og sender spilleren til info siden
    public void info_btn()
    {
        selectedCont = continentText.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
