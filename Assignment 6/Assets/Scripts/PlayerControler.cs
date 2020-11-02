/*
 * Logan Ross
 * Assignment 6
 * lets the player move
 */

using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class PlayerControler : Character
{
    // Start is called before the first frame update

    private float horizontalInput;
    private float forwardInput;

    private GameManager gm;
    void Start()
    {
        speed = 5;
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!gm.gameOver)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }

    }
}
