using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Conditionals : MonoBehaviour
{
    public UnityEvent OnEvent, OffEvent;
    public bool OnBool;
    public int Number;
    public string Password;

    void Update()
    {
        if (OnBool)
        {
            OnEvent.Invoke();
        }
        else
        {
            OffEvent.Invoke();
        }

        print(Number >= 10 ? "Greater" : "Lesser");

        print(Password == "OU812" ? "The password is correct" : "The password is incorrect");
    }
}
