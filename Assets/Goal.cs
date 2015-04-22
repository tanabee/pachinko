using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	public Vector3 startPosition;

	void OnTriggerEnter(Collider other) {
		other.transform.position = startPosition;
	}
}
