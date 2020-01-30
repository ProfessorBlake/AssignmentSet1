using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
	public GameObject WallRight;
	public GameObject WallLeft;
	public float MoveSpeed;

	private void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(MoveSpeed, 0f, 0f);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-MoveSpeed, 0f, 0f);
		}

		if(transform.position.x < 0f)
		{
			WallLeft.SetActive(false);
		}
		else
		{
			WallLeft.SetActive(true);
		}

		if (transform.position.x > 0f)
		{
			WallRight.SetActive(false);
		}
		else
		{
			WallRight.SetActive(true);
		}
	}
}
