var LowCam : Camera;
var HighCam : Camera;

function OnGUI () {

     	if (GUI.Button (Rect (400,48,48,24), "Cam1")) {
          LowCam.enabled = true;
          HighCam.enabled = false;
     }
		if (GUI.Button (Rect (400,24,48,24), "Cam2")) {
          LowCam.enabled = false;
          HighCam.enabled = true;
     }
}