using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSystem
{
    public ObjectPool<Powerup> powerUpPool = new ObjectPool<Powerup>();

    public List<Powerup> SpawnEnemies(int columns, int rows)
    {
        List<Powerup> powerUpList = new List<Powerup>();
        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                Powerup newpowerUp = powerUpPool.RequestItem();
                powerUpList.Add(newpowerUp);
                newpowerUp.Pickup += EnemyDeath;
            }
        }
        return powerUpList;
    }

    private void EnemyDeath(Powerup enemy)
    {
        powerUpPool.DisableItem(enemy);
    }
}