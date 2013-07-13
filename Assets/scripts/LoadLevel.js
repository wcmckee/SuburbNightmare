var LowCam : Camera;
var HighCam : Camera;

function OnGUI () {

     	if (GUI.Button (Rect (400,48,48,24), "LowCam")) {
          LowCam.enabled = true;
          HighCam.enabled = false;
     }
		if (GUI.Button (Rect (400,24,48,24), "HighCam")) {
          LowCam.enabled = false;
          HighCam.enabled = true;
     }
}