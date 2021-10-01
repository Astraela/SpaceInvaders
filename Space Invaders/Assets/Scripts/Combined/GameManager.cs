using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private EnemySystem enemySystem = new EnemySystem();
    private PowerUpSystem powerUpSystem = new PowerUpSystem();
    private InputHandler inputHandler = new InputHandler();
    private Player player = new Player();
    private MoveLeftCommand moveLeftCommand = new MoveLeftCommand();
    private MoveRightCommand moveRightCommand = new MoveRightCommand();
    private FireBulletCommand fireBulletCommand = new FireBulletCommand();


    void Awake()
    {
        
    }

    void Start(){
        SetCommands();
        enemySystem.SpawnEnemies(10,6);
    }

    void Update()
    {
        EventSystem.RaiseEvent(EventType.UPDATE);
    }

    private void SetCommands()
    {
        moveLeftCommand.moveAbleObject = player;
        moveRightCommand.moveAbleObject = player;
        fireBulletCommand.player = player;

        inputHandler.aCommand = moveLeftCommand;
        inputHandler.dCommand = moveRightCommand;
        inputHandler.spaceCommand = fireBulletCommand;
    }
}
