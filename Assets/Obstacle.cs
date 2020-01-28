using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	public float MoveSpeed;

	private void Update()
	{
		transform.position += new Vector3(MoveSpeed, 0f, 0f);

		if (Mathf.Abs(transform.position.x) > 6f)
		{
			Debug.Log("Turned around.");
			MoveSpeed *= -1f;
		}
	}
}
