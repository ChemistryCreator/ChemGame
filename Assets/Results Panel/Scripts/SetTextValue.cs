using UnityEngine;
using System.Collections;

public class SetTextValue : MonoBehaviour {

	public string typeOfText;
	public GameObject newSprite;

	void Awake() {
		Screen.showCursor = true;
	}

	// Use this for initialization
	void Start () {

		ChangeText ();
		if (newSprite) {
			CheckAnswers ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ChangeText(){
		if (typeOfText == "mysteryBP") {
			GetComponent<TextMesh> ().text = ((LegitCompound)ChemGame.Instance.mysteryCompound).BoilingPoint.ToString() + "° C";
		} else if (typeOfText == "guessBP") {
			GetComponent<TextMesh> ().text = ((LegitCompound)ChemGame.Instance.chosenCompound).BoilingPoint.ToString() + "° C";
		} else if (typeOfText == "mysteryFP") {
			GetComponent<TextMesh> ().text = ((LegitCompound)ChemGame.Instance.mysteryCompound).FreezingPoint.ToString() + "° C";
		} else if (typeOfText == "guessFP") {
			GetComponent<TextMesh> ().text = ((LegitCompound)ChemGame.Instance.chosenCompound).FreezingPoint.ToString() + "° C";
		} else if (typeOfText == "mysteryCompound") {
			GetComponent<TextMesh> ().text = ChemGame.Instance.mysteryCompound.Name;
		} else if (typeOfText == "guessCompound") {
			GetComponent<TextMesh> ().text = ChemGame.Instance.chosenCompound.Name;
		}
	}

	void CheckAnswers () {
		if (typeOfText == "mysteryBP") {
			if (((LegitCompound)ChemGame.Instance.mysteryCompound).BoilingPoint
			    == ((LegitCompound)ChemGame.Instance.chosenCompound).BoilingPoint) {
				newSprite.GetComponent<RightOrWrong> ().SetCorrect ();
			}
		} else if (typeOfText == "mysteryFP") {
			if (((LegitCompound)ChemGame.Instance.mysteryCompound).FreezingPoint
			    == ((LegitCompound)ChemGame.Instance.chosenCompound).FreezingPoint) {
				newSprite.GetComponent<RightOrWrong> ().SetCorrect ();
			}
		} else if (typeOfText == "mysteryCompound") {
			if (((LegitCompound)ChemGame.Instance.mysteryCompound).Name
			    == ((LegitCompound)ChemGame.Instance.chosenCompound).Name) {
				newSprite.GetComponent<RightOrWrong> ().SetCorrect ();
			}
		} 

	}

}
