using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceBall : MonoBehaviour {

		Vector3 velocity     = new Vector3(0.0f, 1.0f, 0.0f);
		float floorHeight    = 0.5f;
		float sleepThreshold = 0.05f;
		float gravity        = -9.8f;

		void Start()
		{
			transform.position = new Vector3(0.0f, 1.5f, 0.0f);
		}

		void FixedUpdate()
		{
			if (velocity.magnitude > sleepThreshold || transform.position.y > floorHeight)
			{
				velocity += new Vector3(0.0f, gravity * Time.fixedDeltaTime, 0.0f);
			}

			transform.position += velocity * Time.fixedDeltaTime;
			if (transform.position.y <= floorHeight)
			{
				transform.position = new Vector3(0.0f, floorHeight, 0.0f);
				velocity.y = -velocity.y;
			}
		}
	}