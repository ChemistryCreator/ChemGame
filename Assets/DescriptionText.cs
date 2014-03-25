using UnityEngine;
using System.Collections;

public class DescriptionText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnGui () {
		GUI.Label(new Rect (20,20,100,100), "blablalba\nbasasdlj");

	}

	// Update is called once per frame
	void Update () {
	
	}
}
