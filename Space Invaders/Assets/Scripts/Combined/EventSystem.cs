using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Consider generating this from an string to enum tool for easy editing?
public enum EventType
{
    //ADD STUFF
    UPDATE = 1,
}

public delegate void EventCallback();

public static class EventSystem
{
    private static Dictionary<EventType, List<EventCallback>> eventRegister = new Dictionary<EventType, List<EventCallback>>();

    public static void Subscribe( EventType evt, EventCallback func )
    {
        if ( !eventRegister.ContainsKey( evt ) )
        {
            eventRegister[evt] = new List<EventCallback>();
        }

        eventRegister[evt].Add(func);
    }

    public static void Unsubscribe( EventType evt, EventCallback func )
    {
        if ( eventRegister.ContainsKey( evt ) )
        {
            eventRegister[evt].Remove(func);
        }
    }

    public static void RaiseEvent( EventType evt)
    {
        if ( eventRegister.ContainsKey( evt ) )
        {
            foreach( EventCallback e in eventRegister[evt] )
            {
                e.Invoke();
            }
        }
    }
}
