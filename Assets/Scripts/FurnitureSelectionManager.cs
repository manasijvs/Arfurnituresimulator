using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FurnitureSelectionManager : MonoBehaviour
{
    public GameObject[] furnitures;
    public int currentfurniture;
    public bool inGamePlayScene = false;
    // Start is called before the first frame update
    void Start()
    {
        int selectedfurniture = PlayerPrefs.GetInt("SelectedfurnitureID");

        // Ensure all furniture objects are disabled initially
        foreach (GameObject furniture in furnitures)
        {
            furniture.SetActive(false);
        }

        // If in gameplay scene, activate the selected furniture only
        if (inGamePlayScene)
        {
            furnitures[selectedfurniture].SetActive(true);
            currentfurniture = selectedfurniture;
        }
        else
        {
            // Default to first furniture if not in gameplay scene
            currentfurniture = 0;
            furnitures[currentfurniture].SetActive(true);
        }
    }

    public void Next()
    {
        // Disable currently active furniture
        furnitures[currentfurniture].SetActive(false);

        // Move to the next furniture, looping back if at the end
        currentfurniture = (currentfurniture + 1) % furnitures.Length;

        // Enable only the newly selected furniture
        furnitures[currentfurniture].SetActive(true);
    }

    public void Prev()
    {
        // Disable currently active furniture
        furnitures[currentfurniture].SetActive(false);

        // Move to the previous furniture, looping back if at the beginning
        currentfurniture = (currentfurniture - 1 + furnitures.Length) % furnitures.Length;

        // Enable only the newly selected furniture
        furnitures[currentfurniture].SetActive(true);
    }


    public void Select()
    {
        PlayerPrefs.SetInt("SelectedfurnitureID", currentfurniture);
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
    }
}
