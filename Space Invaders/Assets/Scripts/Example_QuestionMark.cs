using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_QuestionMark
{
    //On Creating we just subscribe UPDATE to update
    public Example_QuestionMark(){
        EventSystem.Subscribe(EventType.UPDATE,Update);
    }
    
    void Update()
    {
        //Runs every Update after Start is ran
        Debug.Log("Runnin");
    }

}
