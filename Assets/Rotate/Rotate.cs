using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// 回転するスピード
	public float speed = 10f;
	
	// Update is called once per frame
	void Update () {
		// オブジェクトを回転させる
		RotatePin ();
	}

	void RotatePin () {
		// オブジェクトを回転　（transform コンポーネントを利用）
		transform.Rotate (Vector3.up * speed * Time.deltaTime);
	}
}
