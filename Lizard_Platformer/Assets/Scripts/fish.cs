using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : Animal
{
	public Color FinColor;
	
	// Use this for initialization
	void Start ()
	{
		newcColor = Color.blue;
		GetComponent<SpriteRenderer>().color = SkinColor;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,5,0);
	}
}
