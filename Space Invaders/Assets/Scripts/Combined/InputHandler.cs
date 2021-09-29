using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    public ICommand aCommand;
    public ICommand dCommand;
    public ICommand spaceCommand;

    public InputHandler(){
        EventSystem.Subscribe(EventType.UPDATE,HandleInput);
    }

    public void HandleInput()
    {
        if      (UnityEngine.Input.GetKeyDown(KeyCode.A))     { aCommand.Execute(); }
        else if (UnityEngine.Input.GetKeyDown(KeyCode.D))     { dCommand.Execute(); }
        else if (UnityEngine.Input.GetKeyDown(KeyCode.Space)) { spaceCommand.Execute(); }
    }
}
