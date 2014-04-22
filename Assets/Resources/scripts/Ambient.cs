using UnityEngine;
using System.Collections;

public class Ambient : MonoBehaviour {
	public GameObject one, two, three;
	public int j=0;
	private bool keyDown = false;

	// Use this for initialization
	void Start () {
		one = GameObject.Find ("Amb1");
		two = GameObject.Find ("Amb2");
		three = GameObject.Find ("Amb3");
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.H)	) {
			j++;
			keyDown=true;
		}

		if (Input.GetKey("h")&& keyDown) {
			//keyDown=false;
		}

		if (j % 3 == 0) {
		
			if (one.audio.isPlaying == false)
			{
				one.audio.Play();
			}
			two.audio.Pause ();
			three.audio.Pause ();

		}

		if (j % 3 == 2) {

			if (three.audio.isPlaying == false)
			{
				three.audio.Play();
			}
			two.audio.Pause ();
			one.audio.Pause ();
		}

		if (j % 3 == 1) {

			if (two.audio.isPlaying == false)
			{
				two.audio.Play();
			}
			one.audio.Pause ();
			three.audio.Pause ();
				
		}
	

	}
}
