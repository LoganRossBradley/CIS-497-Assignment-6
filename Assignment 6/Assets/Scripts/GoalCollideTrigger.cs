/*
 * Logan Ross
 * Assignment 6
 * Handles when the player runs into the goal
 */

using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class GoalCollideTrigger : MonoBehaviour, Trigger
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
        if (other.CompareTag("Player") && !triggered && this.isActiveAndEnabled)
        {
            triggered = true;
            gm.won = true;
            gm.gameOver = true;
        }
    }
}
