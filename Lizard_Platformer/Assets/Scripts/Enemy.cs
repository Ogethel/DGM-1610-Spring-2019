using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
 private void OnTriggerStay(Collider other)
 {
  HealthBarScript.health -= 10f;
 }
}
