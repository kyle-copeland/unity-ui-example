using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HitPlayer : MonoBehaviour {

	public UnityEvent onBulletHit;

	private Animator anim;
	private bool isVulnerable = true;

	// Utilizing C# properties to manage vulnerability state
	private bool Vulnerable {
		get {
			return isVulnerable;
		}
		set {
			isVulnerable = value;
			anim.SetBool ("isVulnerable", isVulnerable);
		}
	}

	private void Awake() {
		anim = GetComponent<Animator> ();
		Vulnerable = true;
		onBulletHit.AddListener (() => {
			MakeInvulnerable();
		});
	}

	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Bullet")) {
			Destroy (other.gameObject);
			if (Vulnerable) {
				onBulletHit.Invoke ();
			}
		}
	}

	private void MakeVulnerable() {
		Vulnerable = true;
	}

	private void MakeInvulnerable() {
		Vulnerable = false;
		Invoke ("MakeVulnerable", 2.0f);
	}

}