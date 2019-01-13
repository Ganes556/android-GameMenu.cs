using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class PauseSetting : MonoBehaviour {
	public static bool GamePause = false;
	//public  AudioSource audioSource;
	//public GameObject pauseButtonUI;
	// Update is called once per frame
	public void PauseGame() {
		if (GamePause) {
			resume();

		} else {

			pause ();

		}
	

	}
	void resume(){
		//pauseButtonUI.SetActive (false);
		//audioSource.Play();
		Time.timeScale = 1f;
		GamePause = false;
		//return;
	}


	void pause(){
		//pauseButtonUI.SetActive (true);
		//audioSource.Pause();
		Time.timeScale = 0f;
		GamePause = true;
		//return;
	}
}
