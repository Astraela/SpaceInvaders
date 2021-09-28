using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iDamageable
{
    float health {get;}

    public void Damage(float _damage);

}
