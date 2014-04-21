using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class identify : MonoBehaviour {
	public AudioSource source;
	public AudioClip good;
	public AudioClip bad;
	public TextMesh text;

	private Dictionary<string, string> disp;
	private string index = "";
	private bool stg1 = false;

	// Use this for initialization
	void Start () {
		string n1 = "coral";
		string n2 = "jfish";
		string n3 = "school";
		string n4 = "whale";
		string f1 = "It is an important\nmember of the\nreef building\ncommunity and can\ncause painful stings\nto unwary divers.";
		string f2 = "The 24 tentacles\nmay trail behind\nas far as 10 feet\nand its sting is\noften irritating.";
		string f3 = "The bluestripe\nsnapper is one\nof the most widespread\nspecies of the\nLutjanidae.";
		string f4 = "The long black\nand white tail\nfin and the pectoral\nfins have unique\npatterns, which\nmake individual whales\nidentifiable";
		disp = new Dictionary<string, string> ();
		disp.Add (n1, f1);
		disp.Add (n2, f2);
		disp.Add (n3, f3);
		disp.Add (n4, f4);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z) && !index.Equals("") && !stg1){
			//play sound
			stg1 = true;
			if(index.Equals("coral") || index.Equals("jfish")){
				source.PlayOneShot(bad,0.5f);
			}else{
				source.PlayOneShot(good,0.5f);
			}
		}else if (Input.GetKeyDown (KeyCode.Z) && !index.Equals("") && stg1){
			//display info
			Debug.Log(disp[index]);
			text.text = disp[index];
		}
	}

	void OnTriggerEnter(Collider other) {
		index = other.name;
	}

	void OnTriggerExit(Collider other) {
		index = "";
		stg1 = false;
		text.text = "";
	}
}
