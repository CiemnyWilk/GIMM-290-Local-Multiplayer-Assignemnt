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

    int lengthofx;
    int lengthofabilities;


    private void AbilitySpawner()
    {
        int i = UnityEngine.Random.Range(0, lengthofx);
        int j = UnityEngine.Random.Range(0, lengthofabilities);
        Vector3 spawnPosition = new Vector3(xChords[i], yChords[i], zChords[i]);
        Instantiate(abilites[j], spawnPosition, Quaternion.identity);
    }





    //Timers
    private void Start()
    {
        StartCoroutine(DelayAction(5f));
        lengthofx = xChords.Length - 1;
        lengthofabilities = abilites.Length - 1;
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
        DoDelayAction(10f);
    }
}
