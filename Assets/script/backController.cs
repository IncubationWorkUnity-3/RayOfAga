using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backController : MonoBehaviour {

	public float speed = 1.0f;
	// Update is called once per frame
	void Update () {
		transform.Translate (0, -speed, 0);
		if (transform.position.y < -134f) {
			transform.position = new Vector3 (0, 134f, 0);
		}
	}
}
