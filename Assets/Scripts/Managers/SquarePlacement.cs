using UnityEngine;

public class SquarePlacement : MonoBehaviour
{
    public static SquarePlacement instance;

    public bool canPlace = false;
    public GameObject squarePrefab;
    private Camera mainCamera;
    public CoinManager coinManager;
    public Collider2D placementArea; // Define a Collider2D to represent your placement area.
    public bool inPlacementMode = false; // Add a flag for placement mode.

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canPlace && coinManager.coinCount >= 10)
        {
            Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            if (placementArea.OverlapPoint(mousePosition))
            {
                Instantiate(squarePrefab, mousePosition, Quaternion.identity);
                canPlace = false;
                coinManager.DeductCoins(10);
                ExitPlacementMode(); // Exit placement mode after placement.
            }
        }
    }

    public void AllowPlacement()
    {
        canPlace = true;
        inPlacementMode = true; // Set the flag to true when in placement mode.
    }

    public void ExitPlacementMode()
    {
        inPlacementMode = false; // Set the flag to false when exiting placement mode.
    }
}
