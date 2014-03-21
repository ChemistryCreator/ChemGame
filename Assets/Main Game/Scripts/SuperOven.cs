using UnityEngine;
using System.Collections;

public class SuperOven : MonoBehaviour {

	public GameObject player;
	public bool test = false;
	public GameObject thermometer;
	public BackgroundMat thermometerBG;
	public static float tempPerSecond = 5; 

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		thermometer = GameObject.Find ("Thermometer");
		thermometerBG = thermometer.GetComponentInChildren<BackgroundMat> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other) {

		if (other.gameObject.tag == "Player") {
			test = true;
			Thermometer.temp += (Time.deltaTime) * tempPerSecond;
		}
	}

	void OnTriggerEnter(Collider other) {
			
		if (other.gameObject.tag == "Player") {
			thermometerBG.SetMat("Hot");	
		}

	}

//	void OnCollisionEnter(Collision other) {
//		
//		if (other.gameObject.tag == "Player") {
//			test = true;
//			Destroy (other.gameObject);
//		}
//	}

}
