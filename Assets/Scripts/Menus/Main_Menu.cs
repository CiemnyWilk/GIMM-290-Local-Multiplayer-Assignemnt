using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject levelSelectMenu;
    [SerializeField] private GameObject optionsMenu;
    [SerializeField] private GameObject howToMenu;
    
    public void mainMenuActive()
    {
        // Set the main menu to active
        mainMenu.SetActive(true);
        // Set the level select menu to inactive
        levelSelectMenu.SetActive(false);
        // Set the options menu to inactive
        optionsMenu.SetActive(false);
        // Set the how to menu to inactive
        howToMenu.SetActive(false);
    }

    public void LevelSelect()
    {
        // Set the level select menu to active
        levelSelectMenu.SetActive(true);
        // Set the main menu to inactive
        mainMenu.SetActive(false);
    }

    public void Level1()
    {
        // Load the game scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level_1");
    }

    public void Options()
    {
        // Set the options menu to active
        optionsMenu.SetActive(true);
        // Set the main menu to inactive
        mainMenu.SetActive(false);
    }

    public void HowTo()
    {
        // Set the how to menu to active
        howToMenu.SetActive(true);
        // Set the main menu to inactive
        mainMenu.SetActive(false);
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
}
