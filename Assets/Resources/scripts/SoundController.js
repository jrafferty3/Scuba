#pragma strict

@script RequireComponent(AudioSource)

var lowOxygen: AudioClip;
var highNitrogen: AudioClip;
var damage: AudioClip;
var weather: AudioClip;
private var keyDown = false;

function Update () {
	if (!keyDown) {
		if (Input.GetKey("u")) {
			audio.PlayOneShot(lowOxygen, 0.3);
			keyDown = true;
		}
		else if (Input.GetKey("i")) {
			audio.PlayOneShot(highNitrogen, 0.3);
			keyDown = true;
		}
		else if (Input.GetKey("o")) {
			audio.PlayOneShot(damage, 0.3);
			keyDown = true;
		}
		else if (Input.GetKey("p")) {
			audio.PlayOneShot(weather, 0.3);
			keyDown = true;
		}
		
	}
	else {
		if (!Input.GetKey("u") && !Input.GetKey("i") && !Input.GetKey("o") && !Input.GetKey("p")) {
			keyDown = false;
		}
	}
	
}