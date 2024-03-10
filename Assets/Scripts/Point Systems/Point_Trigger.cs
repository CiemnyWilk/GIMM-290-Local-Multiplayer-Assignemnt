using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Trigger : MonoBehaviour
{
    [SerializeField] private bool player1;
    [SerializeField] private GameObject EventHandler;

    private int p1 = 1;
    private int p2 = 2;

    public bool isSafe = true;

    void Update()
    {
        Debug.Log(isSafe);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Score" && player1 == true)
        {
            if (isSafe == false)
            {
                Debug.Log(isSafe);
                Managers.ScoreCounter.IncrementScore(p1);
            }
            else
            {
                Debug.Log("Player 2 is safe");
            }
        }

        if (other.tag == "Score" && player1 == false)
        {
            if (isSafe == false)
            {
                Debug.Log(isSafe);
                Managers.ScoreCounter.IncrementScore(p2);
            }
            else
            {
                Debug.Log("Player 1 is safe");
            }
        }
    }
}
