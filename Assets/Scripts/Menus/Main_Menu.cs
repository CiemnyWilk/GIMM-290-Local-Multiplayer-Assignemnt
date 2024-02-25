using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject levelSelectMenu;
    [SerializeField] private GameObject optionsMenu;
    [SerializeField] private GameObject howToMenu;
    
    
    public void LevelSelect()
    {
        // Set the level select menu to active
        levelSelectMenu.SetActive(true);
        // Set the main menu to inactive
        mainMenu.SetActive(false);
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
}
