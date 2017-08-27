﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillLighting : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.GetComponent<LightingBehavior>()) {
			Destroy (other.gameObject);
		}

	}
}
