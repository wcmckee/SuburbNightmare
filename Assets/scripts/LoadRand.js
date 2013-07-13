function OnGUI () {

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect (256,302,128,48), "Explore")) {
		Application.LoadLevel(Random.Range(1, 6));
	}
	if (GUI.Button (Rect (256,350,128,48), "Quit")) {
	Application.Quit();
	}
}