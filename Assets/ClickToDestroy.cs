using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ClickToDestroy : MonoBehaviour
{
    public GameObject imagePrefab; // The image prefab to instantiate
    public int numberOfImages = 10; // Number of images to spawn
    public float minX = -5f; // Minimum X position for spawning
    public float maxX = 5f; // Maximum X position for spawning
    public float minY = -3f; // Minimum Y position for spawning
    public float maxY = 3f; // Maximum Y position for spawning
    public int pointsPerImage = 10; // Points awarded per destroyed image
    public TMP_Text scoreText; // Reference to the TextMeshPro text object to display score

    private int score = 0; // Current score

    void Start()
    {
        UpdateScoreText(); // Update the score text initially
        // Spawn images randomly
        for (int i = 0; i < numberOfImages; i++)
        {
            SpawnImage();
        }
    }

    void UpdateScoreText()
    {
        // Update the score text
        scoreText.text = "Score: " + score.ToString();
    }

    void SpawnImage()
    {
        // Generate random position for spawning
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        // Instantiate the image prefab as a child of the Canvas
        GameObject newImage = Instantiate(imagePrefab, transform);
        RectTransform rectTransform = newImage.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = spawnPosition;
        newImage.tag = "Image"; // Set tag for easy identification

        // Add EventTrigger component to detect clicks on the image
        EventTrigger trigger = newImage.AddComponent<EventTrigger>();

        // Create a new entry for pointer click event
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((eventData) => { OnImageClicked(newImage); });

        // Add the entry to the triggers list
        trigger.triggers.Add(entry);
    }

    void OnImageClicked(GameObject clickedImage)
    {
        Destroy(clickedImage); // Destroy the clicked image
        score += pointsPerImage; // Increase the score
        UpdateScoreText(); // Update the score text
        SpawnImage();
    }
}
