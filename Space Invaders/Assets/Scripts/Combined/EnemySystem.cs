using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem
{
    public ObjectPool<Enemy> enemyPool = new ObjectPool<Enemy>();

    public List<Enemy> SpawnEnemies(int columns, int rows)
    {
        List<Enemy> enemyList = new List<Enemy>();
        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                Enemy newEnemy = enemyPool.RequestItem();
                enemyList.Add(newEnemy);
                newEnemy.death += EnemyDeath;
            }
        }
        return enemyList;
    }

    private void EnemyDeath(Enemy enemy)
    {
        enemyPool.DisableItem(enemy);
    }
}
