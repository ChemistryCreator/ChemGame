using UnityEngine;
using System.Collections;

public class AnswerOptions : MonoBehaviour {

	private int buttonHeight = 30;
	private int buttonWidth = 100;

	void OnGUI() {
		if (GUI.Button (new Rect (0, 0, buttonWidth, buttonHeight), "Correct 1")) {
			Application.LoadLevel("Results");
		}
		if (GUI.Button (new Rect (buttonWidth, 0, buttonWidth, buttonHeight), "Correct 2")) {
			Application.LoadLevel("Results");
		}
		if (GUI.Button (new Rect (buttonWidth * 2, 0, buttonWidth, buttonHeight), "Wrong 1")) {
			Application.LoadLevel("Results");
		}
		if (GUI.Button (new Rect (buttonWidth * 3, 0, buttonWidth, buttonHeight), "Wrong 2")) {
			Application.LoadLevel("Results");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
