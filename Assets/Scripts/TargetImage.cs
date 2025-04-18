using UnityEngine;

public class TargetImage : MonoBehaviour
{
    public GameObject[] furnitures; // Assign all furniture prefabs in Inspector

    void Start()
    {
        // Get the selected furniture index from Scene 1
        int selectedFurniture = PlayerPrefs.GetInt("SelectedfurnitureID", 0);
        Debug.Log("Selected Furniture ID: " + selectedFurniture);

        // Disable all furniture first
        foreach (GameObject furniture in furnitures)
        {
            furniture.SetActive(false);
        }

        // Enable only the selected furniture
        if (selectedFurniture >= 0 && selectedFurniture < furnitures.Length)
        {
            furnitures[selectedFurniture].SetActive(true);
            Debug.Log(" Activated furniture index: " + selectedFurniture);
        }
        else
        {
            Debug.LogError("⚠ Invalid furniture index: " + selectedFurniture);
        }
    }
}
