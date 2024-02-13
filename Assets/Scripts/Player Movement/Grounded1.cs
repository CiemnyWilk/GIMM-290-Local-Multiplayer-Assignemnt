using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded1 : MonoBehaviour
{
    GameObject Player;

    //Only used to grab Player Object
    private void Start()
    {
        Player = gameObject.transform.gameObject;
    }

    //Detects when collider has touched the ground
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ground")
        {
            Player.GetComponent<P1Movement>().isGrounded = true;
        }
    }

    //Detects when players collider is no longer touching ground
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "ground")
        {
            Player.GetComponent<P1Movement>().isGrounded = false;
        }
    }
}
