using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour

{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime); // Bullet Speed
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
      Destroy(gameObject); // Destorys Bullet on Collision
    }
}
