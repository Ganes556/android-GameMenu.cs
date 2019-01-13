using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagroundObject : MonoBehaviour {
	public AudioSource myAudio;
	public static GameObject bgmobject;
	void Awake(){
		if (bgmobject) {
			Destroy (gameObject);

			return;
		} 
		myAudio.Play();
		bgmobject = gameObject;
	}
}
