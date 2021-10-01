using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem
{
    public ObjectPool<Powerup> PowerUpPool = new ObjectPool<Powerup>();
    
    public List<Powerup> SpawnEnemies(int columns, int rows){
        List<Powerup> Powerup = new List<Powerup>();
        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                Powerup newPowerup = PowerUpPool.RequestItem();
                Powerup.Add(newPowerup);
                newPowerup.death += EnemyDeath;
            }
        }
        return Powerup;
    }

    private void EnemyDeath(Powerup enemy){
        PowerUpPool.DisableItem(enemy);
    }
}
