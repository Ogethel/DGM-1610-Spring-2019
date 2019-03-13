using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{
	public UnityEvent Event;
	public string Name;
	public FloatData Health;
	public FloatData Speed;
	public bool CanMove;

	protected Color newcColor;
		
	public Color SkinColor;

	public void Move()
	{
		print("Move");
	}

	private void Start () 
	{
		Event.Invoke();
	}
	
	private void Update () 
	{
	
	}
}
