#pragma strict

@script RequireComponent(AudioSource)

var lowOxygen: AudioClip;
var highNitrogen: AudioClip;
var damage: AudioClip;
var weather: AudioClip;
var returntoBoat: AudioClip;
private var keyDown = false;

function Update () {
	if (!keyDown) {
		if (Input.GetKey("u")) {
			audio.PlayOneShot(lowOxygen, 0.6);
			keyDown = true;
		}
		else if (Input.GetKey("i")) {
			audio.PlayOneShot(highNitrogen, 0.6);
			keyDown = true;
		}
		else if (Input.GetKey("o")) {
			audio.PlayOneShot(damage, 0.6);
			keyDown = true;
		}
		else if (Input.GetKey("p")) {
			audio.PlayOneShot(weather, 0.6);
			keyDown = true;
		}
		else if (Input.GetKey("y")) {
			audio.PlayOneShot(returntoBoat, 0.6);
			keyDown = true;
		}
		
	}
	else {
		if (!Input.GetKey("u") && !Input.GetKey("i") && !Input.GetKey("o") && !Input.GetKey("p") && !Input.GetKey("y")) {
			keyDown = false;
		}
	}
	
}