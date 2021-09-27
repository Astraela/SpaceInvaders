using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Example_QuestionMark example;
    void Start()
    {
        example = new Example_QuestionMark();
    }

    // Update is called once per frame
    void Update()
    {
        EventSystem.RaiseEvent(EventType.UPDATE);
    }
}
