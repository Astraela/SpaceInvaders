using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : ICommand
{
    public IMovable moveAbleObject;
    
    public void Execute()
    {
        // move object to Left
    }
}
