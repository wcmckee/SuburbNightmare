var letterPause = 0.2;
var sound : AudioClip;
 
private var word;
 
function Start () {
	word = guiText.text;
	guiText.text = "";
	TypeText ();
}
 
function TypeText () {
	for (var letter in word.ToCharArray()) {
		guiText.text += letter;
		if (sound)
			audio.PlayOneShot (sound);
		yield WaitForSeconds (letterPause);
	}		
}