using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
	
//	public Transform spawnPoint;
	public GameObject prefab;

	public int numberOfObjects = 20;
	public float radius = 15f;

	void Start() {
		for (int i = 0; i < numberOfObjects; i++) {
			float angle = i * Mathf.PI * 2 / numberOfObjects;
			Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
			Instantiate(prefab, pos, Quaternion.identity);
		}
	}

//	void OnTriggerEnter (Collider other) {
//		Instantiate (prefab, spawnPoint.position, spawnPoint.rotation);
//	}
}
