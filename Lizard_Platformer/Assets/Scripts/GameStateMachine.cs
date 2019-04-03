using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameStateMachine : ScriptableObject
{
    public UnityEvent StartingEvent, PlayingEvent, EndingEvent;

    public enum States
    {
        Starting,
        Playing,
        Ending
    }

    public States CurrentStates;

    public void ChangeState(States newState)
    {
        CurrentStates = newState;
    }

    public void OnSwitch()
    {
        switch (CurrentStates)
        {
            case States.Starting:
                StartingEvent.Invoke();
                break;
            case States.Playing:
                PlayingEvent.Invoke();
                break;
            case States.Ending:
                EndingEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
