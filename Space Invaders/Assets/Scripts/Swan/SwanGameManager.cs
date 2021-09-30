using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwanGameManager : MonoBehaviour
{
    private EnemySystem enemySystem;

    void Awake()
    {
        enemySystem = new EnemySystem();
        IBullet bullet = new PlayerBullet();
        IBullet spreadShot = new SpreadShot(bullet);
        IBullet rapidFireShot = new RapidFireShot(spreadShot);
        IBullet clusterShot = new ClusterShot(rapidFireShot);
        IBullet piercingShot = new PiercingShot(clusterShot);
        Debug.Log(piercingShot.GetBulletType());
    }

    void Start()
    {
        enemySystem.SpawnEnemies(10, 6);
    }

    void Update()
    {
        EventSystem.RaiseEvent(EventType.UPDATE);
        //Todo: For every powerup Pickup add one BulletDecorator that get lost on Death
    }
}
