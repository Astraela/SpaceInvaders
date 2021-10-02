using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gemaakt door: Amy & Swan
public class Powerup: iPoolAble
{
    private bool _active;
    bool iPoolAble.active { get => _active; set => _active = value; }

    public delegate void powerDel(Powerup powerup);
    public powerDel pickup;

    public Transform transform;

    public void SetPosition(Vector3 _position){
        //transform.position = _position;
    }

    //todo: Move the Powerup down. 
    public void Update()
    {
        //todo: on PlayerPickup distance to player
        //todo: slowly falls to the bottom and dispears
    }

    public Bullet Pickup()
    {

        //todo: logic for incrmental increase of powerup by one
        Bullet bullet = new PlayerBullet();
        Bullet spreadShot = new SpreadShot(bullet);
        Bullet rapidFireShot = new RapidFireShot(spreadShot);
        Bullet clusterShot = new ClusterShot(rapidFireShot);
        Bullet piercingShot = new PiercingShot(clusterShot);
        return piercingShot;
    }

    void iPoolAble.OnEnableObject()
    {
        EventSystem.Subscribe(EventType.UPDATE, Update);
    }

    //TODO: Hide EnemyObject
    void iPoolAble.OnDisableObject()
    {
        EventSystem.Unsubscribe(EventType.UPDATE, Update);
    }

    ~Powerup() => GameObject.Destroy(transform.gameObject);
}
