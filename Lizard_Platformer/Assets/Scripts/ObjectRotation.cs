using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public float rot_x = 2;
    public float rot_y = 2;
    public float rot_z = 2;
    
    void Update()
    {
        transform.Rotate(rot_x,rot_y,rot_z);
    }
}
