using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gemaakt door: Amy & Swan
public class PowerUpSystem
{
    public ObjectPool<Powerup> powerUpPool = new ObjectPool<Powerup>();

    public void SpawnPowerup(Vector3 _position)
    {
        Powerup newpowerUp = powerUpPool.RequestItem();
        newpowerUp.SetPosition(_position);
        newpowerUp.pickup += Pickup;
    }

    private void Pickup(Powerup _powerup)
    {
        powerUpPool.DisableItem(_powerup);
    }
}