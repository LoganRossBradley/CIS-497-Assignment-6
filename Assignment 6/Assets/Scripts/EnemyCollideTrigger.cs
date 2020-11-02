/*
 * Logan Ross
 * Assignment 6
 * handles when the player runs into an enemy
 */

using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class EnemyCollideTrigger : MonoBehaviour, Trigger
{
    public GameManager gm;
    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            gm.gameOver = true;
        }
    }
}
