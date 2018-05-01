using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiation : MonoBehaviour {

	// Instantiates a prefab in a grid

	public GameObject prefab;
	public float gridX = 5f;
	public float gridY = 5f;
	public float spacing = 2f;

	void Start() {
		for (int y = 0; y < gridY; y++) {
			for (int x = 0; x < gridX; x++) {
				Vector3 pos = new Vector3(x, 1, y) * spacing;
				Instantiate(prefab, pos, Quaternion.identity);
			}
		}
	}
}
