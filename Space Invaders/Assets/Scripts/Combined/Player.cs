using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IMovable, IDamageable
{
    public float speed { get; set; }
    public float health { get; set; }
    public GameObject moveAbleObject { get; set; }
    public Bullet bullet = new Bullet();

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
}
