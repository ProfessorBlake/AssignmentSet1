// Allows this script to use these namespaces.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A class contains public and private variables and functions.
public class Basics : MonoBehaviour
{
	public string Message;

	private float delay = 100f;

	// Because 'Basics' inherits from MonoBehaviour, this script can be attached to gameobjects 
	// and automatically calls some functions like Start(), which will be called one time when this 
	// script is enabled in a scene.
    void Start()
    {
		Debug.Log("Hello world!");
    }

    // Another MonoBehavior function, this is called every frame of the game loop.
    void Update()
    {
		delay = delay - 1f;
        if(delay <= 0f)
		{
			Debug.Log(Message);
			delay = 100f;
		}
    }
}
