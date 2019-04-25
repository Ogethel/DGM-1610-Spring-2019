using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;


public class CollectionCounter : MonoBehaviour
{

    public int value = 5;
    public int minValue = 0;
    public float waitTime = 3;

    public UnityEvent OnCountEvent, OnEndEvent;

    public void startColCounter()
    {
        StartCoroutine(RunCollectionCounter());
    }
    private IEnumerator RunCollectionCounter()
    {
        var WaitObject = new WaitForSeconds(waitTime);
        while (value > minValue)
        {
            yield return WaitObject;
            OnCountEvent.Invoke();
            value--;
        }
        yield return WaitObject;
        OnEndEvent.Invoke();
    }
}