using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMegaMan : MonoBehaviour
{
	public bool IsAlive = true;
	public float WalkSpeed = 0.1f;
	public int Lives = 5;
	
    void Update()
    {
		if(IsAlive == false)
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				Restart(2);
			}

			return;
		}

		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(0f, WalkSpeed, 0f);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += new Vector3(0f, -WalkSpeed, 0f);
		}
		
		CheckDie();
	}

	private void CheckDie()
	{
		if(Mathf.Abs(transform.position.y) >= 10.5f)
		{
			Debug.Log("Went too far.");
			IsAlive = false;
		}
	}

	private void Restart(int cost)
	{
		transform.position = Vector3.zero;
		IsAlive = true;
		Lives -= cost;
		Debug.Log("Restarted. Lives = " + Lives);
	}
}
