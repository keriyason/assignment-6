using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Charcter
{
    public static event Action<Enemy> OnEnemyKilled;
    [SerializeField] private int maxHealth = 3;
    public override void Awake()
    {
        base.Awake();
        health = maxHealth;
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

        OnEnemyKilled?.Invoke(this);
    }
}
