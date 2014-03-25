using UnityEngine;
using System.Collections;

public class AnswerOptions : MonoBehaviour {

	private int buttonHeight = 30;
	private int buttonWidth = 100;

	public ICompound[] answerOptions = new ICompound[4];

	void OnGUI() {
		Screen.showCursor = true;
		if (GUI.Button (new Rect (0, 0, buttonWidth, buttonHeight), ChemGame.Instance.compoundChoices[0].Name)) {
			this.LoadResultsScreen(0);
		}
		if (GUI.Button (new Rect (buttonWidth, 0, buttonWidth, buttonHeight), ChemGame.Instance.compoundChoices[1].Name)) {
			this.LoadResultsScreen(1);
		}
		if (GUI.Button (new Rect (buttonWidth * 2, 0, buttonWidth, buttonHeight), ChemGame.Instance.compoundChoices[2].Name)) {
			this.LoadResultsScreen(2);
		}
		if (GUI.Button (new Rect (buttonWidth * 3, 0, buttonWidth, buttonHeight), ChemGame.Instance.compoundChoices[3].Name)) {
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
