using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSystem
{
    public ObjectPool<Powerup> PowerupPool = new ObjectPool<Powerup>();

    public List<Powerup> SpawnEnemies(int columns, int rows)
    {
        List<Powerup> enemyList = new List<Powerup>();
        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                Powerup newEnemy = PowerupPool.RequestItem();
                enemyList.Add(newEnemy);
                newEnemy.death += EnemyDeath;
            }
        }
        return enemyList;
    }

    private void EnemyDeath(Powerup enemy)
    {
        PowerupPool.DisableItem(enemy);
    }
}