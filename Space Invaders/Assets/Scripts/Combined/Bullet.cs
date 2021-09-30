using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet
{
    public float speed;
    public float damage;
    public GameObject bulletPrefab;
    public int amountOfPojectiles;

    public virtual string GetBulletType(){
        return "Normal bullet";
    }

    public void Shoot(Vector2 _startPos, Vector2 _direction)
    {
        // instantiate bullet prefab
    }
}
