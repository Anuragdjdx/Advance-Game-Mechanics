using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Obiter_1 : MonoBehaviour 
{

	public Transform pivot = null;
	private Transform ThisTransform = null;
	private Quaternion Desrot = Quaternion.identity;


	public float PivotDistance = 5f;
	public float RotSpeed = 10f;
	private float RotX = 0f;
	private float RotY = 0f;

	// Use this for initialization
	void Start () 
	{
		ThisTransform = GetComponent<Transform> ();
				
	}
	
	// Update is called once per frame
	void Update () 
	{

		float Horz = CrossPlatformInputManager.GetAxis ("Horizontal");
		float Vert = CrossPlatformInputManager.GetAxis ("Vertical");

		RotX += Vert * Time.deltaTime * RotSpeed;
		RotY += Horz * Time.deltaTime * RotSpeed;

		Quaternion YRot = Quaternion.Euler (0f, RotY, 0f);
		Desrot = YRot * Quaternion.Euler (RotX, 0f, 0f);

		ThisTransform.position = pivot.position + ThisTransform.rotation * Vector3.forward * -PivotDistance;

			
		
	}
}
