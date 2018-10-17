using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMySound : MonoBehaviour {
    public AudioClip soundToPlay;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Y))
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
        }
	}
}
