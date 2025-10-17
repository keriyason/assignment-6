using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Charcter
{
    public Weapon weapon;

    public override void Update()
    {
        base.Update();

        if (Input.GetMouseButtonDown(0) && weapon != null) // Left Click Fires Weapon
        {
            weapon.Fire();
        }
    }
    public void Collect(GameObject item)
    {
        Destroy(item);
        Debug.Log("Item Collected!");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            Collect(other.gameObject);
        }
    }
}