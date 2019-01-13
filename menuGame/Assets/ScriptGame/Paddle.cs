using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public float speed = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.A)) {
            pos.x = Mathf.Clamp(pos.x - speed, -6f, 6f);
            transform.position = pos;
        } else if (Input.GetKey(KeyCode.D)) {
            pos.x = Mathf.Clamp(pos.x + speed, -6f, 6f);
            transform.position = pos;
        }
	}   
}
