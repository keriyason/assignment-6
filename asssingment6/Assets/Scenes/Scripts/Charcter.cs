using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Charcter : MonoBehaviour
{
    public int health = 100; //health amount
    public float speed = 5f; // speed
    public Rigidbody2D rb;

   public Vector2 moveDirection; // Move Direction
   public Vector2 mousePosition; // Mouse Direction

    public virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public virtual void Update()

    {
        Move(); // Move Method
    }

    public virtual void FixedUpdate()
    {
       
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed); // Movement

        Vector2 aimDirection = mousePosition - rb.position; // Mouse Aim
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;

    }

    public virtual void Move()
    {
        float mouseX = Input.GetAxisRaw("Horizontal"); // Move Left and Right
        float mouseY = Input.GetAxisRaw("Vertical"); // Move Up and Down

        moveDirection = new Vector2(mouseX, mouseY).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public virtual void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
