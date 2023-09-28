using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquarePlacement : MonoBehaviour
{
    public bool canPlace = false;
    public GameObject squarePrefab;
    private Camera mainCamera;
    public CoinManager coinManager; 

    public void AllowPlacement()
    {
        canPlace = true;
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
            Instantiate(squarePrefab, mousePosition, Quaternion.identity);
            canPlace = false;
            
            coinManager.DeductCoins(10);
        }
    }
}