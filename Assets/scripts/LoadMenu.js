function OnGUI () {

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect (48,24,48,24), "Menu")) {
		Application.LoadLevel (0);
	}
}