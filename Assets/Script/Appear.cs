using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour {
    public GameObject Button;
    public AudioClip soundToPlay;
    float timer = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= 2.39 && timer <+ 2.41)
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
        }
        if (timer >= 3.1)
        {
            Button.SetActive(true);
        }
    }
}
