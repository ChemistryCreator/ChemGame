using UnityEngine;
using System.Collections;

public class MouseCursor : MonoBehaviour {

	public Texture2D originalCursor;
	
	
	public float cursorSizeX = 32;  // set to width of your cursor texture
	public float cursorSizeY = 32;  // set to height of your cursor texture
	
	static bool showOriginal = true;
	
	void Start(){
		Screen.showCursor = false;
		//Screen.lockCursor = true;
	}
	
	
	void OnGUI(){
		
		if(showOriginal == true){
			GUI.DrawTexture (new Rect(Input.mousePosition.x-cursorSizeX/2 + cursorSizeX/2, (Screen.height-Input.mousePosition.y)-cursorSizeY/2 + cursorSizeY/2, cursorSizeX, cursorSizeY),originalCursor);
		}
	}
}