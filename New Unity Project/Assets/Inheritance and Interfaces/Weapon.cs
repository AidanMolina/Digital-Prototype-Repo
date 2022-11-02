using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour, IDamageable, IInteractable
{
    public float Cooldown { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Destroyed()
    {
        throw new System.NotImplementedException();
    }

    public abstract void Inspect();

    public void Interact()
    {
        Debug.Log("My cooldown is: " + Cooldown + "\n"
                    + "My Health is: " + Health);
    }

    public void TakeDamage()
    {
        throw new System.NotImplementedException();
    }
}

public class Mace : Weapon{

    public override void Inspect()
    {
        throw new System.NotImplementedException();
    }
}