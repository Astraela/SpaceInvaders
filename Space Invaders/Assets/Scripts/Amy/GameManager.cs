using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private EnemySystem enemySystem;

    void Awake()
    {
        enemySystem = new EnemySystem();
    }

    void Start(){
        enemySystem.SpawnEnemies(10,6);
    }

    void Update()
    {
        EventSystem.RaiseEvent(EventType.UPDATE);
    }
}
