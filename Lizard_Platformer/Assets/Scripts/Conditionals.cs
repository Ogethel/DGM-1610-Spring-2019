using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public bool CanWalk;
    public int Number;
    public string Password;

    void Update()
    {
        print(CanWalk ? "True" : "false");

        print(Number >= 10 ? "Greater" : "Lesser");

        print(Password == "OU812" ? "The password is correct" : "The password is incorrect");
    }
}
