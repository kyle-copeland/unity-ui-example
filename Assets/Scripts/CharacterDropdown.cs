using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDropdown : MonoBehaviour {

	public CharacterSettings characterSettings;
	private Dropdown characterDropdown;

	public void Awake() {
		characterDropdown = GetComponent<Dropdown> ();
	}

	public void SetCharacterName(int optionSelected) {
		characterSettings.characterName = characterDropdown.options[optionSelected].text;
	}
}
