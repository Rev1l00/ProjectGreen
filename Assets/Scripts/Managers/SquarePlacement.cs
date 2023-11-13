using UnityEngine;

public class SquarePlacement : MonoBehaviour
{
    public static SquarePlacement instance;

    // Definerer objekter
    public GameObject squarePrefab;
    private Camera mainCamera;
    public CoinManager coinManager;
    public Collider2D placementArea;
    
    // Definerer variabler
    public bool canPlace = false;
    public bool inPlacementMode = false;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        mainCamera = Camera.main;   // Henter kameraet
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canPlace && coinManager.coinCount >= 10) // Sjekker om brukkeren trykker, kan plasere og har nokk penger
        {
            Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition); // Henter lokasjonen til musepekeren

            if (placementArea.OverlapPoint(mousePosition))  // Sjekker om brukeren har trykket på ett gyldig område
            {
                Instantiate(squarePrefab, mousePosition, Quaternion.identity);  // Plasserer ett ikon der spilleren har trykket
                canPlace = false;
                coinManager.DeductCoins(10);    // Tar bort 10 mynter
                inPlacementMode = false;
            }
        }
    }

    // Gjør sånn at man kan plassere en research stasjon når man har trykket på en knapp
    public void AllowPlacement()
    {
        canPlace = true;
        inPlacementMode = true;
    }
}
