using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_trigger : MonoBehaviour
{
    GameObject eventHandler;

    //How to change what ability is given
    private int abilitySelected = 0;
    [SerializeField] bool speedAbility;

    void Start()
    {
        eventHandler = GameObject.Find("EventSystem");
        if (speedAbility == true)
        {
            abilitySelected = 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ability_Trigger_P1")
        {
            eventHandler.gameObject.GetComponent<Abilites_Handler>().P1AbilityTriggered(abilitySelected);
        }
        else if (other.tag == "Ability_Trigger_P2")
        {
            Debug.Log("P2 Ability Triggered");
            //add sending data to event system
        }
    }
}
