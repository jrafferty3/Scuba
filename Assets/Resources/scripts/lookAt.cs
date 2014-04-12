using UnityEngine;
using System.Collections;

public class lookAt: MonoBehaviour
{
	//values that will be set in the Inspector
	public Transform Target;
	public float RotationSpeed;
	
	//values for internal use
	private Quaternion _lookRotation;
	private Vector3 _direction;
	
	// Update is called once per frame
	void Update()
	{
		//find the vector pointing from our position to the target
		transform.LookAt (Target);
	}
}
