using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI() {
		if (GUI.Button (new Rect (150,100,300,75), "Start Game")) {
			print ("You clicked the button!");
			Application.LoadLevel("Main Game");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
