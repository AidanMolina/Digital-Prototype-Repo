using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public float Cooldown{get; set;}

    public int Health {get; set;}

    public void TakeDamage();

    public void Destroyed();
}
