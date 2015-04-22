using UnityEngine;
using System.Collections;

public class Metronome : MonoBehaviour {

	public float speed;
	public float startAngle;
	public float endAngle;

	// Update is called once per frame
	void Update () {

		// sin 値を計算
		float value = Mathf.Abs(Mathf.Sin (Time.time));
		float angle = Mathf.Lerp(startAngle, endAngle, value);

		//transform.rotation = Quaternion.Euler(0f, angle, 0f);
		transform.localRotation = Quaternion.Euler (0f, angle, 0f);

	}
}
