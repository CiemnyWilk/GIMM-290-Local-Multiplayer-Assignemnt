using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ability_Trigger_P1")
        {
            Debug.Log("P1 Ability Triggered");
            //Add sending data to event system
        }
        else if (other.tag == "Ability_Trigger_P2")
        {
            Debug.Log("P2 Ability Triggered");
            //add sending data to event system
        }
    }
}
