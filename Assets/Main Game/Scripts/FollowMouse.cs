using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {

	public bool followMouse = true;
	private float depth = 10.0f;

	void OnGUI() {
		if (Event.current.type == EventType.MouseDown) {
			followMouse = !followMouse;
			Screen.showCursor = !followMouse;
		}
	}

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!followMouse) {
			return;	
		}
		Vector3 mousePositionVector = Input.mousePosition;
		Vector3 wantedPosition = Camera.main.ScreenToWorldPoint(
			new Vector3(
				mousePositionVector.x, 
				mousePositionVector.y, 
				depth)
			);
		transform.position = wantedPosition;
	}
}
