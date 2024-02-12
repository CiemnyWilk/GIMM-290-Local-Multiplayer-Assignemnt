using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_trigger : MonoBehaviour
{
    GameObject eventHandler;

    //How to change what ability is given
    [SerializeField] bool speedAbility;

    void Start()
    {
        eventHandler = GameObject.Find("EventSystem");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ability_Trigger_P1")
        {
            Debug.Log("P1 Ability Triggered");
            eventHandler.gameObject.GetComponent<Abilites_Handler>().P1AbilityTriggered(1);
        }
        else if (other.tag == "Ability_Trigger_P2")
        {
            Debug.Log("P2 Ability Triggered");
            //add sending data to event system
        }
    }
}
