using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Trigger : MonoBehaviour
{
    [SerializeField] private bool player1;
    [SerializeField] private GameObject EventHandler;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Score" && player1 == true)
        {
            EventHandler.GetComponent<ScoreCounter>().p1Score++;
        }

        if (other.tag == "Score" && player1 == false)
        {
            EventHandler.GetComponent<ScoreCounter>().p2Score++;
        }
    }
}
