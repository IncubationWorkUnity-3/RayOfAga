using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Director : MonoBehaviour {

	GameObject handle;
	float x;
	float y;
	GameObject UI;

	// Use this for initialization
	void Start () {
		this.handle = GameObject.Find ("ray");
		this.UI = GameObject.Find ("Text");
	}
	
	// Update is called once per frame
	void Update () {
		this.x = this.handle.transform.position.x;
		this.y = this.handle.transform.position.y;
		this.UI.GetComponent<Text>().text = "X座標:" + x.ToString("F2") + "Y座標:" + y.ToString("F2");
	}
}
