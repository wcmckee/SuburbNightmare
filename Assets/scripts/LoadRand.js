function OnGUI () {

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect (48,24,56,24), "Explore")) {
		Application.LoadLevel(Random.Range(1, 10));
	}
	if (GUI.Button (Rect (48,48,56,24), "Quit")) {
	Application.Quit();
	}
}