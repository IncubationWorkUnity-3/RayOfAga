using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour {

    public float title_speed = 0.05f;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (0, -10f, 0); //タイトルロゴの初期位置 座標(0,-10,0)
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y >= 0) { //もしy座標が0以上だったら...
			if (Input.anyKeyDown) SceneManager.LoadScene ("test"); //何らかのキーが押されたらシーンをtestに切り替える
			
		} else { //もしy座標が0より小さかったら...
			transform.Translate (0, title_speed, 0); //y軸を +0.05
			if (Input.anyKey) transform.position = new Vector3 (0, 0f, 0); //何らかのキーが押されたら座標を(0,0,0)に

		}
	}
}
