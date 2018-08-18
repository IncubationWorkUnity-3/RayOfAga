using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayController : MonoBehaviour {

	public float speed = 2f;
	public float slow;
	public int charge = 0;
    static private Vector3 moveVector;
    static private Vector3 Restart = new Vector3(0.0f, 0.0f, 0.0f);//※ゲーム完成時には位置の初期化は消しておく

    public GameObject bullet;
    
    static private int i;


    // Update is called once per frame
    void FixedUpdate () {
        //弾丸
        	i++;
		if (i == 6) {
			if (Input.GetKey (KeyCode.Z)) {
				Instantiate (bullet, transform.position, Quaternion.identity);
			}
			i = 0;
		}

		//体当たり
		if (Input.GetKey (KeyCode.X)) {
			slow = 0.2f;
			if (charge <= 100) {
				charge++;
			}
		}else if(charge >= 100){
			transform.Translate (0, 40, 0);
			charge = 0;
		} else {
			slow = 1.0f;
			charge = 0;
		}

        //動き
        {
            moveVector = new Vector3(0, 0, 0);
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                moveVector -= Vector3.right;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                moveVector += Vector3.right;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                moveVector += Vector3.up;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                moveVector -= Vector3.up;
            }
            moveVector = moveVector.normalized;
            transform.Translate(moveVector * (speed * slow));
        }

        //範囲
        {
            if (transform.position.x < -48f)
            {
                transform.position = new Vector3(-48f, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 48f)
            {
                transform.position = new Vector3(48f, transform.position.y, transform.position.z);
            }
            if (transform.position.y < -64f)
            {
                transform.position = new Vector3(transform.position.x, -64f, transform.position.z);
            }
            if (transform.position.y > 64f)
            {
                transform.position = new Vector3(transform.position.x, 64f, transform.position.z);
            }
        }

        //位置の初期化
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = Restart;
        }
    }
}
