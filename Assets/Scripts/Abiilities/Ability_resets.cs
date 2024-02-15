using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_resets : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;

    //Resets the speed of players
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




    //Resets the jump of players
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




    //Resets the shield of players
    void P1ResetShield()
    {
        Debug.Log("P1 Sheild ability has ended");
    }

    void P2ResetShield()
    {
        Debug.Log("P2 Sheild ability has ended");
    }
}
