using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour, IDamageable, IInteractable
{
    public float Cooldown { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Destroyed()
    {
        throw new System.NotImplementedException();
    }

    public void Interact()
    {
        Use();
    }

    public virtual void TakeDamage()
    {
        throw new System.NotImplementedException();
    }

    public abstract void Use();
}

public class potion : Item{
    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}
