using UnityEngine;

public class SquarePlacement : MonoBehaviour
{
    public static SquarePlacement instance;

    // Definerer objekter
    public GameObject squarePrefab;
    private Camera mainCamera;
    public CoinManager coinManager;
    public Collider2D placementArea;
    public ClickManager clickManager;

    private void Awake()
    {
        instance = this;
        mainCamera = Camera.main;   // Henter kameraet
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && clickManager.placingLab && coinManager.coinCount >= 10) // Sjekker om brukkeren trykker, kan plasere og har nokk penger
        {
            Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition); // Henter lokasjonen til musepekeren

            if (placementArea.OverlapPoint(mousePosition))  // Sjekker om brukeren har trykket på ett gyldig område
            {
                Instantiate(squarePrefab, mousePosition, Quaternion.identity);  // Plasserer ett ikon der spilleren har trykket
                coinManager.DeductCoins(10);    // Tar bort 10 mynter
                Debug.Log("Research station was placed");
            }
        }
    }

    // Gjør sånn at man kan plassere en research stasjon når man har trykket på en knapp
    public void AllowPlacement()
    {
        clickManager.placingLab = true;
    }
}
