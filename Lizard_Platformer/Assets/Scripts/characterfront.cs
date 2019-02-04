using UnityEngine;
using UnityEngine.Events;

public class characterfront : MonoBehaviour
{

	public UnityEvent Event;

	private void OnCollisionEnter2D()
	{
		Event.Invoke();
	}

}
