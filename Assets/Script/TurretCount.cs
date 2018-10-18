using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TurretCount : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.FindGameObjectWithTag("Turret") == null)
        {
            SceneManager.LoadScene("FinalBoss");
        }
        GameObject g = GameObject.FindGameObjectWithTag("Turret");
        Debug.Log(g.name);
	}
}
