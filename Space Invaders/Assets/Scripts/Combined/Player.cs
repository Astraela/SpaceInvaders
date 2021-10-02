using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gemaakt door: Aaron
public class Player : IMovable, IDamageable
{
    public float speed { get; set; }
    public float health { get; set; }
    public GameObject moveAbleObject { get; set; }
    public Bullet bullet = new Bullet();
    public PowerUpSystem powerUpSystem;

    public Player(PowerUpSystem _powerUpSystem){
        powerUpSystem = _powerUpSystem;
        EventSystem.Subscribe(EventType.UPDATE,Update);
    }

    private void Update(){
        foreach(Powerup powerup in powerUpSystem.powerUpPool){
            //Detect collision using Vector3.DistanceTo()
        }
    }

    public void FireBullet()
    {
        // shoot bullet from position to direction
    }
    
    public void TakeDamage(float _damage)
    {
        health -= _damage;

        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        // kill player game over
    }
    ~Player() => GameObject.Destroy(moveAbleObject);
}
