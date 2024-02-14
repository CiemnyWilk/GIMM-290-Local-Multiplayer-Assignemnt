using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_resets : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    
    void P1ResetSpeed()
    {
        Debug.Log("Ability has ended");
        player1.GetComponent<P1Movement>().p1moveSpeed = 2f;
    }

    void P2ResetSpeed()
    {
        Debug.Log("Ability has ended");
        player2.GetComponent<P2Movement>().p2moveSpeed = 2f;
    }

    void P1ResetJump()
    {
        Debug.Log("Ability has ended");
        player1.GetComponent<P1Movement>().p1jumpForce = 5f;
    }

    void P2ResetJump()
    {
        Debug.Log("Ability has ended");
        player2.GetComponent<P2Movement>().p2jumpForce = 5f;
    }
}
