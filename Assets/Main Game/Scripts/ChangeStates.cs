using UnityEngine;
using System.Collections;

public class ChangeStates : MonoBehaviour {

	public GameObject SolidParticlePrefab;
	public GameObject LiquidParticlePrefab;
	public GameObject GasParticlePrefab;
	public GameObject childParticles;
	private Thermometer thermometer;
	private Quaternion zeroRotation;
	private Vector3 currentLocation;
	private float temp;
	public string stateTest;
	public string currentState;
	public string name;

	void Start () {
		currentLocation = transform.position;
		zeroRotation = Quaternion.Euler(0f,0f,0f);
		thermometer = GameObject.Find ("Thermometer").GetComponent<Thermometer> ();
		currentState = "Solid";
		childParticles = (Instantiate (SolidParticlePrefab, currentLocation, zeroRotation) as GameObject);
		childParticles.transform.parent = this.gameObject.transform;
	}

	void Update() {
		temp = thermometer.GetTemp ();
		stateTest = ((LegitCompound)ChemGame.Instance.mysteryCompound).GetState (temp).ToString();
		currentLocation = transform.position;

		if (stateTest != currentState) {
			currentState = stateTest;
			ChangeParticles(currentState);
		}

		name =  ((LegitCompound)ChemGame.Instance.mysteryCompound).Name;


	}

	void ChangeParticles (string state) {
		Destroy (childParticles);
		GameObject newPrefab;
		if (state == "Solid") {
			newPrefab = SolidParticlePrefab;
		} else if (state == "Gas") {
			newPrefab = GasParticlePrefab;
		} else {
			newPrefab = LiquidParticlePrefab;
		}

		childParticles = (Instantiate (newPrefab, currentLocation, zeroRotation) as GameObject);
		childParticles.transform.parent = this.gameObject.transform;
	}

}