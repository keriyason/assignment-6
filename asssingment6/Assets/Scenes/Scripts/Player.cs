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
  
}