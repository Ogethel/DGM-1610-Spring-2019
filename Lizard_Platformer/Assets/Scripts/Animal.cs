using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

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
		
	}
	
	private void Update () 
	{
	
	}
}
