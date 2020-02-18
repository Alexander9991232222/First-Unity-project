using Assets.Flat_Platformer_Template.Scripts.AbstractClasses;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit: MonoBehaviour {
    [SerializeField] protected float _moveRate;
    [SerializeField] protected float _hp;
    [SerializeField] protected float _damageAmount;
    [SerializeField] protected Rigidbody _unitRigidBody;

    public float Health { get; protected set; }
    public float Damage { get; protected set; }
    public float Speed { get; protected set; }
 
    protected virtual void Awake()
    {
        Health = _hp;
        Damage = _damageAmount;
        Speed = _moveRate;
    }
}