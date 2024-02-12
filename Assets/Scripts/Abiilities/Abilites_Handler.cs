using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilites_Handler : MonoBehaviour
{
    public void P1AbilityTriggered(int ability)
    {
        Debug.Log("P1 has used ability: " + ability);
    }

    public void P2AbilityTriggered(int ability)
    {
        Debug.Log("P2 has used ability: " + ability);
    }
}
