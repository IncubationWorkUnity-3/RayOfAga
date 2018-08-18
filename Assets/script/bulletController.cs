using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {

	public float BulletSpeed;

	// Update is called once per frame


	void Update () {
		transform.Translate (0, BulletSpeed, 0);
		if (transform.position.y > 64)Destroy (gameObject);
	}
	void OnTriggerEnter2D(Collider2D coll){
		Destroy (coll.gameObject);
		Destroy (gameObject);
	}
}
