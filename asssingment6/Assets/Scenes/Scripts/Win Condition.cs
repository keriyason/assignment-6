using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
    {
        private List<Enemy> enemies = new List<Enemy>();

        private void OnEnable()
        {
            Enemy.OnEnemyKilled += HandleEnemyKilled;
        }

        private void OnDisable()
        {
            Enemy.OnEnemyKilled -= HandleEnemyKilled;
        }

        private void Start()
        {
            enemies.AddRange(FindObjectsOfType<Enemy>()); //Calls to How many enemies are left
        }

        private void HandleEnemyKilled(Enemy enemy)
        {
            if (enemies.Contains(enemy))
            {
                enemies.Remove(enemy);
            }

            if (enemies.Count == 0) // Checking if all enemies are defeated

        {
            WinGame();
            }
        }

        private void WinGame()
        {
            Debug.Log("All slimes defeated! You win!");


           
        }
    }