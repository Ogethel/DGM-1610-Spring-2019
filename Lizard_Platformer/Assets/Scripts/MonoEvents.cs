using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, MouseDownEvent, UpdateEvent, CollisionEnterEvent, TriggerEvent;

    private void Start()
    {
        StartEvent.Invoke();
    }

    private void OnEnable()
    {
        EnableEvent.Invoke();
    }

    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        TriggerEvent.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        CollisionEnterEvent.Invoke();
    }

    private void Update()
    {
        UpdateEvent.Invoke();
    }
}