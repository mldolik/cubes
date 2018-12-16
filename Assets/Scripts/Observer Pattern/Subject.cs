using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject<T> : MonoBehaviour
{
    List<Observer<T>> observers = new List<Observer<T>>();

    public void AttachObserver(Observer<T> observer)
    {
        observers.Add(observer);
    }

    public void DetachObserver(Observer<T> observer)
    {
        observers.Remove(observer);
    }

    public void Notify(T newState)
    {
        foreach (Observer<T> observer in observers)
        {
            observer.OnSubjectUpdate(newState);
        }
    }
}
