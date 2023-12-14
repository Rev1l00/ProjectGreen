using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject uiElementPrefab;
    public Transform uiContainer;

    private List<UIElement> uiElements = new List<UIElement>();
    private List<int> numbers = new List<int>(); // This is the variable you want to monitor

    void Start()
    {
        // For testing purposes, add some initial numbers
        numbers.AddRange(new int[] { 1, 2, 3 });

        // Initialize UI elements based on the initial numbers
        UpdateUIElements();
    }

    void Update()
    {
        // Simulate a change in the numbers variable (you should replace this with your actual variable update logic)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numbers.Add(Random.Range(1, 100));
            UpdateUIElements();
        }
    }

    void UpdateUIElements()
{
    // Destroy existing UI elements
    foreach (var uiElement in uiElements)
    {
        Destroy(uiElement.gameObject);
    }
    uiElements.Clear();

    // Define spacing and initial position
    float spacing = 50f;
    Vector3 position = Vector3.zero;

    // Create new UI elements based on the updated numbers
    foreach (var number in numbers)
    {
        // Instantiate UI element
        GameObject uiElementObject = Instantiate(uiElementPrefab, uiContainer);

        // Position the UI element
        uiElementObject.transform.localPosition = position;

        // Update content
        UIElement uiElement = uiElementObject.GetComponent<UIElement>();
        if (uiElement != null)
        {
            uiElement.UpdateContent(number);
            uiElements.Add(uiElement);
        }
        else
        {
            Debug.LogError("UIElement component not found on prefab.");
        }

        // Update position for the next element
        position.x += spacing;
    }
}

}