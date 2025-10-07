using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Charcter
{
    public Weapon weapon; // Calls to Weapon
  
   private Vector2 mousePosition; //tracks mouse position
    public override void Update()
    {
        base.Update(); // still handles movement
        HandleInput();
        Aim();
    }

    private void HandleInput()
    {
      
        if (Input.GetMouseButton(0) && weapon != null)// Fire weapon on left-click
        {
            weapon.Fire();
        }

        
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);    // Track mouse position
    }

    private void Aim()
    {
        Vector2 aimDirection = mousePosition - (Vector2)rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
}