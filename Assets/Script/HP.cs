using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour {
    public GameObject PauseMenu;
    public GameObject deathCanvas;
    public Slider HealthSlider;
    public Slider HealthSlider2;
    public Text healthText;
    public int health = 10;
    float timer = 0.0f;
    public AudioClip soundToPlay;
    void Start()
    {
        Time.timeScale = 1;
        HealthSlider.GetComponent<Slider>().value = health;
        HealthSlider2.GetComponent<Slider>().value = health;
        healthText.GetComponent<Text>().text = "Health: " + health;
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer > 1.0)
        {
            timer = 0;
            health -= 5;
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
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

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer > 1.0)
        {
            timer = 0;
            health -= 5;
            healthText.GetComponent<Text>().text = "Health: " + health;
            HealthSlider.GetComponent<Slider>().value = health;
            HealthSlider2.GetComponent<Slider>().value = health;
        }
        if (health <= 0)
        {
            Destroy(PauseMenu);
            deathCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
