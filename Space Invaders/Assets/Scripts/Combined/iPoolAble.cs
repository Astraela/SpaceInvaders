using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iPoolAble
{
    bool active {get;set;}
    void OnEnableObject();
    void OnDisableObject();
}
