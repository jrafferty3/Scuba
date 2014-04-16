using UnityEngine;
using System.Collections;

public class swimming : MonoBehaviour {
	private float start_distance = 2f;
	private float max_dist = 8f;
	public float distance;
	private bool collision = false;
	private bool fast = false;
	public static bool surface = false;

	// Use this for initialization
	void Start () {
		distance = start_distance;
	}

	// Update is called once per frame
	void Update () {
		fast = false;
		if (Input.GetKey (KeyCode.LeftShift)) {
			if(distance < max_dist)
				distance+=0.1f;
		} else {
			if(distance > start_distance)
				distance-=0.1f;
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime*(collision?-1:1);
		} else if (Input.GetKey (KeyCode.S)) {
			transform.position = transform.position + -Camera.main.transform.forward * distance * Time.deltaTime*(collision?-1:1);
		}
		if (Input.GetKey (KeyCode.Q)) {
			if(distance > 4){
				fast = true;
			}
			transform.position = transform.position + Camera.main.transform.up * distance * Time.deltaTime*(collision?-1:1);
		} else if (Input.GetKey (KeyCode.E)) {
			transform.position = transform.position + -Camera.main.transform.up * distance * Time.deltaTime*(collision?-1:1);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position = transform.position + -Camera.main.transform.right * distance * Time.deltaTime*(collision?-1:1);
		}else if (Input.GetKey (KeyCode.D)) {
			transform.position = transform.position + Camera.main.transform.right * distance * Time.deltaTime*(collision?-1:1);
		}
		if (this.transform.position.y > 0) {
			this.transform.position = new Vector3(this.transform.position.x,0,this.transform.position.z);
		}
		if (fast) {
			//play alarm
		}
		if (this.transform.position.y > -0.5) {
			setSurface(true);
		} else {
			setSurface(false);
		}
		if (surface)
			Debug.Log ("surface");
	}

	static void setSurface(bool set){
		surface = set;
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
