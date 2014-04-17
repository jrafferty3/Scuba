using UnityEngine;
using System.Collections;

public class TimeRemain : MonoBehaviour {
	public int timeLeft;
	public int min;
	public int second;
	public TextMesh t;
	public GameObject g;
	public int counter;
	// Use this for initialization
	void Start () {
		timeLeft = 120*60;
		t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
		counter = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (swimming.surface == false) {
			counter++;
			if (counter == 60){

						timeLeft--;
				counter =0;
			}
				}
		min = timeLeft / 60;
		second = timeLeft % 60;
		t.text = min.ToString() + ":" + second.ToString ();
	
	}
}
