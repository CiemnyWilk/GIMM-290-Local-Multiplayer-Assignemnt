using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilites_Handler : MonoBehaviour
{
    //Player Objects
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;

    //Runs all the abilities for P1
    public void P1AbilityTriggered(int ability)
    {
        if (ability == 0)
        {
            Debug.Log("P1 has used an unfinished ability");
        }
        else if (ability == 1)
        {
            Debug.Log("P1 has used speed ability");
            player1.GetComponent<P1Movement>().p1moveSpeed = 5f;
            GetComponent<Ability_resets>().Invoke("P1ResetSpeed", 5f);
        }
        else if (ability == 2)
        {
            Debug.Log("P1 has used jump ability");
            player1.GetComponent<P1Movement>().p1jumpForce = 10f;
            GetComponent<Ability_resets>().Invoke("P1ResetJump", 5f);
        }
        else if (ability == 3)
        {
            Debug.Log("P1 has used shield ability");

            GetComponent<Ability_resets>().Invoke("P1ResetShield", 5f);
        }
    }

    //Runs all the abilities for P2
    public void P2AbilityTriggered(int ability)
    {
        if (ability == 0)
        {
            Debug.Log("P2 has used an unfinished ability");
        }
        else if (ability == 1)
        {
            Debug.Log("P2 has used speed ability");
            player2.GetComponent<P2Movement>().p2moveSpeed = 5f;
            GetComponent<Ability_resets>().Invoke("P2ResetSpeed", 5f);
        }
        else if (ability == 2)
        {
            Debug.Log("P2 has used jump ability");
            player2.GetComponent<P2Movement>().p2jumpForce = 10f;
            GetComponent<Ability_resets>().Invoke("P2ResetJump", 5f);
        }
        else if (ability == 3)
        {
            Debug.Log("P2 has used shield ability");

            GetComponent<Ability_resets>().Invoke("P2ResetShield", 5f);
        }
    }
}
