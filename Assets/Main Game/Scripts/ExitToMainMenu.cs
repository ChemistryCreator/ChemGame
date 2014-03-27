using UnityEngine;
using System.Collections;

public class ExitToMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnMouseDown() {
		Application.LoadLevel("MainMenu");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
