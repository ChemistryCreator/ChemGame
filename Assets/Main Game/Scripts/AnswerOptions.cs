using UnityEngine;
using System.Collections;

public class AnswerOptions : MonoBehaviour {

	private int buttonHeight = 30;
	private int buttonWidth = 125;

	public ICompound[] answerOptions = new ICompound[4];

	public Font myFont;
	public int myFontSize;
	public Color color;

	void OnGUI() {
		//Screen.showCursor = true;

		GUIStyle myStyle = new GUIStyle();
		myStyle.font = myFont;
		myStyle.fontSize = myFontSize;
		myStyle.normal.textColor = color;
		myStyle.alignment = TextAnchor.MiddleCenter;
		myStyle.padding=new RectOffset(0,-5,30,0);

		if (GUI.Button (new Rect (0, 0, buttonWidth, buttonHeight), ChemGame.Instance.compoundChoices[0].Name, myStyle)) {
			this.LoadResultsScreen(0);
		}
		if (GUI.Button (new Rect (buttonWidth, 0, buttonWidth, buttonHeight), ChemGame.Instance.compoundChoices[1].Name, myStyle)) {
			this.LoadResultsScreen(1);
		}
		if (GUI.Button (new Rect (buttonWidth * 2, 0, buttonWidth, buttonHeight), ChemGame.Instance.compoundChoices[2].Name, myStyle)) {
			this.LoadResultsScreen(2);
		}
		if (GUI.Button (new Rect (buttonWidth * 3, 0, buttonWidth, buttonHeight), ChemGame.Instance.compoundChoices[3].Name, myStyle)) {
			this.LoadResultsScreen(3);
		}
	}

	void LoadResultsScreen(int index) {
		ChemGame game = ChemGame.Instance;
		game.chosenCompound = game.compoundChoices [index];
		Application.LoadLevel("Results");
	}

	// Use this for initialization
	void Start () {
		ChemGame.Instance.prepareForNewGame ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
