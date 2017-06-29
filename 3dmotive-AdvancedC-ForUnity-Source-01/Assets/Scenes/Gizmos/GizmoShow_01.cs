using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoShow_01 : MonoBehaviour 
{

	public bool ShowGizmos = true;

	public string MyIcon = string.Empty;

	[Range(0f,100f)]
	public float Range = 10f;

	void OnDrawGizmos()
	{
		if (!ShowGizmos) return; 		

		Gizmos.DrawIcon (transform.position, MyIcon, true);

		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere (transform.position, Range);


		Gizmos.color = Color.green;
		Gizmos.DrawLine (transform.position, transform.position + transform.forward * Range);

			
		
	}
	

}
