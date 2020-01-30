using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
	public bool On;

    public void ToggleWall()
	{
		On = !On;
		Debug.Log(gameObject.name + " " + On);
	}
}
