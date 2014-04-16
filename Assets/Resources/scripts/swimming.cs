using UnityEngine;
using System.Collections;

public class swimming : MonoBehaviour {
	public int start_distance = 4;
	private int distance;
	public static bool collision = false;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftShift)) {
			distance = start_distance*2;
		} else {
			distance = start_distance;
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime*(collision?-1:1);
		} else if (Input.GetKey (KeyCode.S)) {
			transform.position = transform.position + -Camera.main.transform.forward * distance * Time.deltaTime*(collision?-1:1);
		}
		if (Input.GetKey (KeyCode.Q)) {
			transform.position = transform.position + Camera.main.transform.up * distance * Time.deltaTime*(collision?-1:1);
		} else if (Input.GetKey (KeyCode.E)) {
			transform.position = transform.position + -Camera.main.transform.up * distance * Time.deltaTime*(collision?-1:1);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position = transform.position + -Camera.main.transform.right * distance * Time.deltaTime*(collision?-1:1);
		}else if (Input.GetKey (KeyCode.D)) {
			transform.position = transform.position + Camera.main.transform.right * distance * Time.deltaTime*(collision?-1:1);
		}
	}

	void OnCollisionEnter (Collision col)
	{
		collision = true;
	}

	void OnCollisionExit (Collision col)
	{
		collision = false;
	}
}
