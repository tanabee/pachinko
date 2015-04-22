using UnityEngine;
using System.Collections;

public class PowerMeter : MonoBehaviour {

	public Ball ball;
	public float minPower = 30f;
	public float maxPower = 100f;
	
	// Update is called once per frame
	void Update () {
		DoScale ();
	}

	void DoScale () {
		// sin 値を計算
		float value = Mathf.Abs(Mathf.Sin (Time.time));

		ball.power = Mathf.Lerp(minPower, maxPower, value);
		
		// 大きさを変える 
		// 大きさの値を計算
		Vector3 scale = new Vector3 (value, 1f, 1f);
		// 大きさを適用
		transform.localScale = scale;

	}
}
