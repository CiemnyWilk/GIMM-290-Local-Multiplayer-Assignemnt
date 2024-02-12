using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    //Score Variables
    public int p1Score = 0;
    public int p2Score = 0;

    //Score GameObjects
    [SerializeField] private TMP_Text p1Text;
    [SerializeField] private TMP_Text p2Text;

    //win screen
    [SerializeField] private TMP_Text winText;

    public void FixedUpdate()
    {
        //Debug.Log("Player 1 Score: " + p1Score + " Player 2 Score: " + p2Score);
        
        p1Text.SetText("P1 Score: " + p1Score);
        p2Text.SetText("P2 Score: " + p2Score);

        if (p1Score == 10 || p2Score == 10)
        {
            if (p1Score > p2Score)
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
