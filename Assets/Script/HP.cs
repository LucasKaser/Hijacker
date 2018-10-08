﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour {
    public GameObject deathCanvas;
    public Slider HealthSlider;
    public Slider HealthSlider2;
    public Text healthText;
    public int health = 10;
    float timer = 0.0f;
     void Start()
    {
        HealthSlider.GetComponent<Slider>().value = health;
        HealthSlider2.GetComponent<Slider>().value = health;
        healthText.GetComponent<Text>().text = "Health: " + health;
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }
    void OnCollisionEnter(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer > 1.0)
        {
            timer = 0;
            health--;
            healthText.GetComponent<Text>().text = "Health: " + health;
            HealthSlider.GetComponent<Slider>().value = health;
            HealthSlider2.GetComponent<Slider>().value = health;
        }
        if (health <= 0)
        {
            deathCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnCollisionPersist(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer > 1.0)
        {
            timer = 0;
            health--;
            healthText.GetComponent<Text>().text = "Health: " + health;
            HealthSlider.GetComponent<Slider>().value = health;
            HealthSlider2.GetComponent<Slider>().value = health;
        }
        if (health <= 0)
        {
            
            deathCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
