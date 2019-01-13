using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class optionMenu : MonoBehaviour {
	public Slider slider;
	public AudioMixer audioMixer;
	public AudioSource audioSource;

	public void volumeSetting(){
		audioSource.volume = slider.value;
	}


	public void muteVolume()
	{
		audioSource.mute = !audioSource.mute;

	
	}

		
}