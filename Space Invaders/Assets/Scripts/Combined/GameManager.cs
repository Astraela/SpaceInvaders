using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gemaakt door: Iedereen
public class GameManager : MonoBehaviour
{
    private EnemySystem enemySystem;
    public PowerUpSystem powerUpSystem = new PowerUpSystem();
    private InputHandler inputHandler = new InputHandler();
    private Player player; 
    private MoveLeftCommand moveLeftCommand = new MoveLeftCommand();
    private MoveRightCommand moveRightCommand = new MoveRightCommand();
    private FireBulletCommand fireBulletCommand = new FireBulletCommand();

    private void Awake(){
        player = new Player(powerUpSystem);
        enemySystem = new EnemySystem(this);
        SetCommands();
    }

    private void Start(){
        enemySystem.SpawnEnemies(10,6);
    }

    private void Update()
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
