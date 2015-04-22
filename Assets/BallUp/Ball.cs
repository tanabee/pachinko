using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// ジャンプする力
	public float power = 10f;

	// Update is called once per frame
	void Update () {

		// Click Event
		if (Input.GetButtonDown ("Fire1")) {
			Debug.Log ("call jump");
			jump ();
		}
	}

	void jump () { 
		Debug.Log ("jump");

		// force = ジャンプする力（方向も）を決める
		Vector3 force = Vector3.forward * power;

		// 自分自身に 力(farce) を加える
		GetComponent<Rigidbody> ().AddForce (force, ForceMode.Impulse);
	}
}
