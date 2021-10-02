using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gemaakt door: Aaron & Amy
public interface IDamageable
{
    float health { get; set; }
    
    void TakeDamage(float _damage);
    void Die();
}
