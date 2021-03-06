﻿using UnityEngine;
using System.Collections;

public interface IVelocity
{
	Vector3 GetVelocity ();
}

public class BasicMovement : MonoBehaviour
{
	
	public Vector3 Velocity;
	public GameObject Reference;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		var vel = Velocity;
		if (Reference != null) {
			var comp = Reference.GetComponent<IVelocity> ();
			if (comp != null) {
				vel = comp.GetVelocity ();
			}
		}
		transform.position += vel * Time.deltaTime;
	}
}