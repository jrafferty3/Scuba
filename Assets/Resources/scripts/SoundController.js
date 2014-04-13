#pragma strict
var lowOxygen: AudioClip;

var keySounds =  [["o",lowOxygen]];
function Start () {
	
}

function Update () {
	for (var i=0; i<keySounds.length; i++) 
		print(i);
}