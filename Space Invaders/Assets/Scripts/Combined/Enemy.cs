using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : IDamageable, iPoolAble
{
    public GameObject enemy;

    private float _health = 10;
    float IDamageable.health { get => _health; set { _health = value; } }

    private bool _active;
    bool iPoolAble.active { get => _active; set => _active = value; }

    public delegate void del(Enemy enemy);
    public del death;
    private Bullet bullet;

    //todo: Move the enemy right ,left and down. Timer between a random range to Shoot()
    //todo: Detect bullet collision
    public void Update()
    {
        
    }

    private void Shoot()
    {
        bullet.Shoot(enemy.transform.position, new Vector2(1, 0));
    }

    void IDamageable.TakeDamage(float _damage)
    {
        _health -= _damage;
    }

    //todo: Generate Powerup
    void IDamageable.Die()
    {
        death?.Invoke(this);
    }

    //TODO: Show EnemyObject
    void iPoolAble.OnEnableObject()
    {
        EventSystem.Subscribe(EventType.UPDATE, Update);
    }

    //TODO: Hide EnemyObject
    void iPoolAble.OnDisableObject()
    {
        EventSystem.Unsubscribe(EventType.UPDATE, Update);
    }

    ~Enemy() => GameObject.Destroy(enemy);
}
