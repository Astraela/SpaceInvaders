using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : iDamageable, iPoolAble
{
    private GameObject enemy;
    
    private float _health = 10;
    float iDamageable.health {get => _health;}

    private bool _active;
    bool iPoolAble.active { get => _active; set => _active = value; }

    public delegate void del(Enemy enemy);
    public del death;
    private Bullet bullet;
    //todo: Move the enemy right ,left and down. Timer between a random range to Shoot()
    public void Update(){
        
    }

    void Shoot(){
        bullet.Shoot();
    }

    void iDamageable.Damage(float _damage){
        _health -= _damage;
    }

    void Die(){
        death?.Invoke(this);
    }

    //TODO: Show EnemyObject
    void iPoolAble.OnEnableObject()
    {
        EventSystem.Subscribe(EventType.UPDATE,Update);
    }

    //TODO: Hide EnemyObject
    void iPoolAble.OnDisableObject()
    {
        EventSystem.Unsubscribe(EventType.UPDATE,Update);
    }

    ~Enemy() => GameObject.Destroy(enemy);
}
