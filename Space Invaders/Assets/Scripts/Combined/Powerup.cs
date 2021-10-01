using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup 
{
    private Player player = new Player();

    //public Powerup()
    //{
    //    EventSystem.Subscribe(EventType.UPDATE, Update);
    //}

    ////todo: Move the Powerup down. 
    //public void Update()
    //{
    //    //todo: logic for incrmental increase of powerup by one
    //    //Todo: on PlayerPickup distance to player
    //}

    public void Pickup()
    {
        
        //todo: logic for incrmental increase of powerup by one
        Bullet bullet = new PlayerBullet();
        Bullet spreadShot = new SpreadShot(bullet);
        Bullet rapidFireShot = new RapidFireShot(spreadShot);
        Bullet clusterShot = new ClusterShot(rapidFireShot);
        Bullet piercingShot = new PiercingShot(clusterShot);
        player.bullet = bullet;
    }


}
