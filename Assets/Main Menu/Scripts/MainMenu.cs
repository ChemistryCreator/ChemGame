using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void Awake () {
		Screen.SetResolution (600, 400, false);
	}

	void OnGUI() {
//		if (GUI.Button (new Rect (150,100,300,75), "Start Game")) {
//			print ("You clicked the button!");
//			Application.LoadLevel("Main Game");
//		}
	}

	// Use this for initialization
	void Start () {
		//ChemGame.loadAssets ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0)) {
			Application.LoadLevel("Main Game");
		}
	
	}
}
