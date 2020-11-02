using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    private bool step1;
    private bool step2;
    private bool step3;

    public GameObject wall1;
    public GameObject wall2;

    // Start is called before the first frame update
    void Start()
    {
        step1 = true;
        step2 = false;
        step3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(step1)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {
                step1 = false;
                step2 = true;
                Destroy(wall1);
            }
        }
        //else if(step2 )
    }
}
