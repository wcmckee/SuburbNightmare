function OnGUI () {

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect (300,200,156,56), "Menu")) {
		Application.LoadLevel (0);
	}
}