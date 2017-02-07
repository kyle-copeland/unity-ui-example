using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public Transform bullet;
	public float fireRate;

	private void Start() {
		InvokeRepeating ("Fire", fireRate, fireRate);
	}

	private void Fire() {
		Instantiate (bullet);
	}

}
