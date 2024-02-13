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
            Invoke("P1ResetSpeed", 5f);
        }
        // else if (ability == 2)
        // {
        //     Debug.Log("P1 has used jump ability");
        // }
    }

    //Runs all the abilities for P2
    public void P2AbilityTriggered(int ability)
    {
        Debug.Log("P2 has used ability: " + ability);
    }

    void P1ResetSpeed()
    {
        Debug.Log("Ability has ended");
        player1.GetComponent<P1Movement>().p1moveSpeed = 2f;
    }
}
