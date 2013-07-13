var LowCam : Camera;
var HighCam : Camera;

function OnGUI () {

     	if (GUI.Button (Rect (300,200,48,24), "LowCam")) {
          LowCam.enabled = true;
          HighCam.enabled = false;
     }
		if (GUI.Button (Rect (300,88,48,24), "Begin")) {
          LowCam.enabled = false;
          HighCam.enabled = true;
     }
}