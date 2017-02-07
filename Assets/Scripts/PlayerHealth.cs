using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	public Transform healthPanel;

	public void RemoveHealth() {
		Destroy(healthPanel.GetChild (healthPanel.childCount - 1).gameObject);
	}
}
