using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> : IEnumerable where T : iPoolAble
{
    private List<T> activePool = new List<T>();
    private List<T> inactivePool = new List<T>();

    public T AddItem(){
        T newItem = (T)Activator.CreateInstance(typeof(T));
        inactivePool.Add(newItem);
        return newItem;
    }

    public T EnableItem(T item){
        item.OnEnableObject();
        item.active = true;
        if(inactivePool.Contains(item)){
            inactivePool.Remove(item);
        }
        activePool.Add(item);
        return item;
    }

    public void DisableItem(T item){
        if(activePool.Contains(item)){
            activePool.Remove(item);
        }
        item.OnDisableObject();
        item.active = false;
        inactivePool.Add(item);
    }

    public T RequestItem(){
        return EnableItem(inactivePool.Count > 0 ? inactivePool[0] : AddItem());
    }

    public IEnumerator GetEnumerator()
    {
        foreach(T item in activePool){
            yield return item;
        }
    }
}
