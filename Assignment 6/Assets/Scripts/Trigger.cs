/*
 * Logan Ross
 * Assignment 6
 * the base interface that other "trigger" classes inherit from
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Trigger
{
    void OnTriggerEnter(Collider other);
}
