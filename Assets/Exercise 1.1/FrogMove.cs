using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMove : MonoBehaviour
{
	public float MoveSpeed;
    
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(0f, MoveSpeed, 0f);
		}
    }
}
