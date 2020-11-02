using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        health = 120;
        GameManager.instance.score += 5;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem attacks");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("The Golem took " + amount + " points of damage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
