using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Charcter : MonoBehaviour
{
    public int health = 100; //health amount
    public float speed = 5f; // speed
    public Rigidbody2D rb;

    Vector2 moveDirection;

    public virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public virtual void Update()

    {
        Move();
    }

    public virtual void FixedUpdate()
    {
       
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);

    }

    public virtual void Move()
    {
        float mouseX = Input.GetAxisRaw("Horizontal");
        float mouseY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(mouseX, mouseY).normalized;
    }
}
