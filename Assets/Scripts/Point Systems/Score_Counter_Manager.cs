using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score_Counter_Manager : MonoBehaviour, IGameManager
{
    public ManagerStatus status {get; private set;}

    //Score Variables
    public int P1_Score {get; private set;}
    public int P2_Score {get; private set;}

    //Score GameObjects
    [SerializeField] private TMP_Text p1Text;
    [SerializeField] private TMP_Text p2Text;
    [SerializeField] private GameObject activeScores;

    //win screen
    [SerializeField] private TMP_Text winText;
    [SerializeField] private GameObject winScreen;


    public void Startup() {
        Debug.Log("Score counter manager starting...");

        P1_Score = 0;
        P2_Score = 0;

        status = ManagerStatus.Started;
    }

    public void IncrementScore(int player) {
        if (player == 1) {
            P1_Score++;
        } else {
            P2_Score++;
        }

        p1Text.SetText("P1 Score: " + P1_Score);
        p2Text.SetText("P2 Score: " + P2_Score);
    }

    public void FixedUpdate()
    {
        if (P1_Score == 5 || P2_Score == 5)
        {
            activeScores.SetActive(false);
            winScreen.SetActive(true);
            if (P1_Score > P2_Score)
            {
                winText.SetText("Player 1 Wins!");
            }
            else
            {
                winText.SetText("Player 2 Wins!");
            }
        }
    }
}
