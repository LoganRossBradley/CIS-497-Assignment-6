/*
 * Logan Ross
 * Assignment 6
 * example code
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageBonus;

    public Enemy enemyHoldingweapon;

    private void Awake()
    {
        enemyHoldingweapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingweapon);
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats weapon");
    }

    public void Recharge()
    {
        Debug.Log("Recharging Weapon!");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
