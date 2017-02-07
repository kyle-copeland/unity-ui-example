using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingText : MonoBehaviour {

	public CharacterSettings characterSettings;
	public string sentence = "My body's ready!";
	public float scrollSpeed;

	private Text dialogueBox;
	private char[] letters;

	void Awake() {
		dialogueBox = GetComponent<Text> ();
	}

	void Start () {
		var dialogue = characterSettings.characterName + ": " + sentence;
		letters = dialogue.ToCharArray();
		StartCoroutine (GenerateText());
	}

	IEnumerator GenerateText() {
		for (int i = 0; i < letters.Length; i++) {
			dialogueBox.text += letters [i];
			yield return new WaitForSeconds(scrollSpeed);
		}
	}
}
