using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class menuMain: MonoBehaviour {
	public GameObject LoadingScreen;
	public Slider slider;
	public Text TextProgress;

	public void LoadPlay(int sceneIndex)
	{
		StartCoroutine(LoadAsynchronously (sceneIndex)); //coroutine = wait for second
	}
	IEnumerator LoadAsynchronously (int sceneIndex)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);

		LoadingScreen.SetActive (true);

		while (!operation.isDone) {
			
			float progress = Mathf.Clamp01(operation.progress) / .9f;

			slider.value = progress;

			TextProgress.text = progress * 100f + "%";

			yield return null;
		}
	}
	public void keluarDariGame(){
		Debug.Log("Keluar");
		Application.Quit();
	}

	
}
