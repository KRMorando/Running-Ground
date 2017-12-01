using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	private Rigidbody rigidbody;

	private float fDestroyTime = 2f;
	private float fTickTime;

	void Start() {
		rigidbody = GetComponent<Rigidbody>();
	}

	void Update() {
		fTickTime += Time.deltaTime;

		if ( fTickTime >= fDestroyTime) {
				Vector3 up = new Vector3 (0f, 0.0f, 1f);

				rigidbody.AddForce (up);
		}
	}
}