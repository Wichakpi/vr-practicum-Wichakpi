using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
		public GameObject prefabtoSpawn;                // The enemy prefab to be spawned.
		public Transform[] spawnPoints;         // An array of the spawn points this object can spawn from.


		void Start ()
		{
		
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
			Instantiate (prefabtoSpawn, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		}
}



