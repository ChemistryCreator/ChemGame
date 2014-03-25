using System;
using UnityEngine;

public class Thermometer : MonoBehaviour {

	public static float temp = 25;
	TextMesh tm;

	// Use this for initialization
	void Start () {
		tm = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
	}
	
	// Update is called once per frame
	void Update () {
		tm.text = string.Format ("{0:0}", temp);
	}

	public float GetTemp(){
		return temp;
	}
}
