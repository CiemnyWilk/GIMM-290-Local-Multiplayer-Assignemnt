using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Trigger : MonoBehaviour
{
    [SerializeField] private bool player1;
    [SerializeField] private GameObject EventHandler;

    public bool isSafe = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Score" && player1 == true)
        {
            if (isSafe == false)
            {
                EventHandler.GetComponent<ScoreCounter>().p1Score++;
            }
            else
            {
                Debug.Log("Player 1 is safe");
            }
        }

        if (other.tag == "Score" && player1 == false)
        {
                        if (isSafe == false)
            {
                EventHandler.GetComponent<ScoreCounter>().p2Score++;
            }
            else
            {
                Debug.Log("Player 2 is safe");
            }
        }
    }
}
