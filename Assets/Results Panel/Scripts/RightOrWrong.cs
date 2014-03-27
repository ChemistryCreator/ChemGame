using UnityEngine;
using System.Collections;

public class RightOrWrong : MonoBehaviour {
	public Sprite rightSprite;

	void Start () {
	}

	public void SetCorrect () {
		GetComponent<SpriteRenderer>().sprite = rightSprite;
	}

}
