﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {

    public void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Turret") == null)
        {
            SceneManager.LoadScene("Win");
        }
    }

}
