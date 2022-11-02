using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour, IDamageable, IInteractable
{
    public float Cooldown { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public abstract void Speak();

    public abstract void Move();

    public abstract void Teleport();

    public virtual void TakeDamage()
    {
        Health -= 5;
    }

    public virtual void Destroyed()
    {
        throw new System.NotImplementedException();
    }

    public virtual void Interact()
    {
        Speak();
    }
}
