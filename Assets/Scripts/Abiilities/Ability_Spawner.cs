using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability_Spawner : MonoBehaviour
{
    [SerializeField] float[] xChords;
    [SerializeField] float[] yChords;
    [SerializeField] float[] zChords;

    [SerializeField] GameObject[] abilites;

    [SerializeField] int delay;

    int lengthofx;
    int lengthofabilities;


    private void AbilitySpawner()
    {
        int i = UnityEngine.Random.Range(0, lengthofx);
        int j = UnityEngine.Random.Range(0, lengthofabilities);

        Debug.Log("Position: " + i + " Ability: " + j);

        Vector3 spawnPosition = new Vector3(xChords[i], yChords[i], zChords[i]);
        //Instantiate(abilites[j], spawnPosition, Quaternion.identity);

        Instantiate (abilites[j], spawnPosition, abilites[j].transform.rotation);
    }





    //Timers
    private void Start()
    {
        StartCoroutine(DelayAction(5f));
        lengthofx = xChords.Length;
        lengthofabilities = abilites.Length;
    }

    void DoDelayAction(float delayTime)
    {
        StartCoroutine(DelayAction(delayTime));
    }

    IEnumerator DelayAction(float delayTime)
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime);

        //Do the action after the delay time has finished.
        AbilitySpawner();
        DoDelayAction(delay);
    }
}
