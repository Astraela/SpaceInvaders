using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gemaakt door: Amy
public class EnemySystem
{
    public ObjectPool<Enemy> enemyPool = new ObjectPool<Enemy>();
    private GameManager gameManager;

    public EnemySystem(GameManager _gameManager){
        gameManager = _gameManager;
    }

    public List<Enemy> SpawnEnemies(int _columns, int _rows)
    {
        List<Enemy> enemyList = new List<Enemy>();
        for (int x = 0; x < _columns; x++)
        {
            for (int y = 0; y < _rows; y++)
            {
                Enemy newEnemy = enemyPool.RequestItem();
                enemyList.Add(newEnemy);
                newEnemy.death += EnemyDeath;
            }
        }
        return enemyList;
    }

    private void EnemyDeath(Enemy _enemy)
    {
        enemyPool.DisableItem(_enemy);
        gameManager.powerUpSystem.SpawnPowerup(_enemy.enemy.transform.position);
    }
}
