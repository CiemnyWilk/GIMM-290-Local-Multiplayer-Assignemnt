using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int p1Score = 0;
    public int p2Score = 0;

    public void FixedUpdate()
    {
        Debug.Log("Player 1 Score: " + p1Score + " Player 2 Score: " + p2Score);    
    }
}
