using UnityEngine;
using System.Collections;

public class TimeRemain : MonoBehaviour {
	public int timeLeft;
	public TextMesh t;
	public GameObject g;
	// Use this for initialization
	void Start () {
		timeLeft = 100;
		t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
		g = GameObject.Find("First Person Controller");
		Debug.Log (g.GetType());
	}
	
	// Update is called once per frame
	void Update () {
		//if (g.collision == false) {
						timeLeft--;
				//}
		t.text = timeLeft.ToString();
	
	}
}
