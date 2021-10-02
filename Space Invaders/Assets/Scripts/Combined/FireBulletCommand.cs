using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gemaakt door: Swan
public class FireBulletCommand : ICommand
{
    public Player player;
    
    public void Execute()
    {
        player.FireBullet();
    }
}
