using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSound : MonoBehaviour {
	private AudioSource source;
	public AudioClip clip;

	void Awake(){
		source = GetComponent<AudioSource> ();
	}
	void OnTriggerEnter(Collider other){
			//This will play without any testing
			source.Play();
		}
	}
