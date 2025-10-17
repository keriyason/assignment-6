using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Enemy : Charcter
{
    public static event Action<Enemy> OnEnemyKilled;
    [SerializeField] private int maxHealth = 3;
    Transform target;
    public override void Awake()
    {
        base.Awake();
        health = maxHealth; // Sets Base Health
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

        OnEnemyKilled?.Invoke(this); // Game Manager Reference for Enemies Remaining 
    }
    private void Start()
    {
        target = GameObject.Find("Player").transform;
    }
    public override void Update()
    {
       if(target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;
        }
    }
    public override void FixedUpdate()
    {
        if(target)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * speed;
        }
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Charcter>().TakeDamage(25);
        }
    }
}
