/*
 * Logan Ross
 * Assignment 6
 * manages the scripted sequences in the tutorial level (level 1)
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public int  currentStep;

    public GameObject goal;
    public GameObject player;
    public Text tutorialText;

    private bool step3Triggered;

    // Start is called before the first frame update
    void Start()
    {
        currentStep = 1;
        step3Triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentStep == 1)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {
                NextStep();
                tutorialText.text = "Get past the enemy without getting caught!";
            }
        }
        else if(currentStep == 2 && player.transform.position.x > 1.5)
        {
            NextStep();
        }
        else if(currentStep ==3)
        {
            if (!step3Triggered)
            {
                step3Triggered = true;
                tutorialText.text = "You can pause the game at any time by pressing 'P'. Try it!";
            }
            if(Input.GetKeyDown(KeyCode.P))
            {
                NextStep();
                tutorialText.text = "Touch the green cube to advance to the next level";
                goal.SetActive(true);
            }
        }
    }

    public void NextStep()
    {
        currentStep++;
    }
}
