using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_1 : MonoBehaviour 
{
	public float MaxSpeed = 1f;
	private Transform ThisTransform = null;
	public Transform Target = null;
	// Use this for initialization
	void Awake () 
	{
		ThisTransform = GetComponent<Transform> ();		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Quaternion DestRot = Quaternion.LookRotation (Target.position - ThisTransform.position, Vector3.up);

		ThisTransform.rotation = Quaternion.RotateTowards (ThisTransform.rotation, DestRot, MaxSpeed * Time.deltaTime);
	}
}
