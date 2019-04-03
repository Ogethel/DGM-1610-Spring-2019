using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switches : MonoBehaviour
{
    public UnityEvent StartingEvent, PlayingEvent, DyingEvent, EndingEvent;
    
    public enum States
    {
        Starting,
        Playing,
        Dying,
        Ending
    }

    public States CurrentState;
    
 
    private void Update()
    {
        switch (CurrentState)
        {
            case States.Starting:
                break;
                StartingEvent.Invoke();
            case States.Playing:
                break;
                PlayingEvent.Invoke();
            case States.Ending:
                break;
                DyingEvent.Invoke();
            case States.Dying:
                break;
                EndingEvent.Invoke();
            default:
                throw new ArgumentOutOfRangeException();
        }  
    }
}
