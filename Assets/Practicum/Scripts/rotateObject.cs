using UnityEngine;
using System.Collections;

public class rotateObject : MonoBehaviour {
	public float speed = -1.0f;

	void Update () {
		transform.Rotate(Vector3.right * speed * Time.deltaTime);
	}
}