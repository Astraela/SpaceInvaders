using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletCommand : ICommand
{
    public Player player;
    
    public void Execute()
    {
        player.FireBullet();
    }
}
