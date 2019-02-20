using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, MouseDownEvent, UpdateEvent;
    
    void Start()
    {
        StartEvent.Invoke();
    }

    private void OnEnable()
    {
        print("Enable");
    }

    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
