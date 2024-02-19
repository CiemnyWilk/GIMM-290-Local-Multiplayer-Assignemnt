using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_trigger : MonoBehaviour
{
    GameObject eventHandler;

    //How to change what ability is given
    private int abilitySelected = 0;
    [SerializeField] bool speedAbility;
    [SerializeField] bool jumpAbility;
    [SerializeField] bool shieldAbility;

    void Start()
    {
        eventHandler = GameObject.Find("EventSystem");
        if (speedAbility == true)
        {
            abilitySelected = 1;
        }
        else if (jumpAbility == true)
        {
            abilitySelected = 2;
        }
        else if (shieldAbility == true)
        {
            abilitySelected = 3;
        }
        else
        {
            abilitySelected = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ability_Trigger_P1")
        {
            eventHandler.gameObject.GetComponent<Abilites_Handler>().P1AbilityTriggered(abilitySelected);
            Destroy(gameObject);
        }
        else if (other.tag == "Ability_Trigger_P2")
        {
            eventHandler.gameObject.GetComponent<Abilites_Handler>().P2AbilityTriggered(abilitySelected);
            Destroy(gameObject);
        }
    }
}
