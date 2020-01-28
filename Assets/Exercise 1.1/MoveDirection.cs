using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : MonoBehaviour
{
	public float XSpeed;
	public float YSpeed;
	public float Width;

	private void Update()
	{
		if(transform.position.x > Width || transform.position.x < -Width)
		{
			transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
		}

		transform.position += new Vector3(XSpeed, YSpeed, 0f);
	}
}
