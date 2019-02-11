using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mammal : Animal
{

	public int FurCount = 10000;
	public float EatingSpeed = 0.4f;
	public bool ItCanEat = true;
	public UnityEvent Event;

	public Color SkinColor;
	
	// Use this for initialization
	void Start () {
		Event.Invoke();
	}
	
	// Update is called once per frame
	void Update () {
		//Do work
	}
}
