using UnityEngine;
using System.Collections;
using System;

public class HealthPickup : MonoBehaviour {
	void OnTriggerEnter(Collider _collider) {
		if(_collider.tag == "Player") {
			PlayerHealth playerhealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
			
			playerhealth.AddjustCurrentHealth(10);
			Destroy(gameObject);
		}
	}
}
