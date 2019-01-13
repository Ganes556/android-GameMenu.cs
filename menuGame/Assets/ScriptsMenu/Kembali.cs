using System.Collections;

using UnityEngine;
using UnityEngine.UI;
public class Kembali : MonoBehaviour {
	
	public GameObject OptionMenu;
	public GameObject HelpMenu;
	public GameObject Menu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			OptionMenu.SetActive (false);
			HelpMenu.SetActive (false);
			Menu.SetActive (true);

		} 


	}
}
