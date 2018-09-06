using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clab : MonoBehaviour {
	public ParticleSystem particle;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(0,0.1f,0);
	}
	void OnTriggerEnter2D(Collider2D coll){
		//Instantiate (particle, transform.position, Quaternion.identity);
		Destroy (coll.gameObject);
	}
}
