using UnityEngine;
using System.Collections;

public class SuperOven : MonoBehaviour {

	public GameObject player;
	public bool test = false;
	public GameObject thermometer;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		thermometer = GameObject.Find ("Thermometer");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Player") {
			test = true;
			Thermometer.temp++;
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
