using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
	public float Speed;

	private float resetPoint = 5f;

	private void Update()
	{
		transform.position = transform.position + new Vector3(0f, Speed, 0f);

		if(transform.position.y > resetPoint)
		{
			transform.position = new Vector3(transform.position.x, -resetPoint, 0f);
		}
	}
}
