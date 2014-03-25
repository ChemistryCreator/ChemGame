using UnityEngine;
using System.Collections;

public class BackgroundMat : MonoBehaviour {

	public Material HotMat;
	public Material CoolMat;
	public Material NormalMat;

	// Use this for initialization
	void Start () {
		renderer.material = NormalMat;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Set the type of background for the thermometer
	public void SetMat(string matKind)
	{
		if (matKind == "Cold") {
			renderer.material = CoolMat;
		} else if (matKind == "Hot") {
			renderer.material = HotMat;
		} else {
			renderer.material = NormalMat;
		}
	}
}
