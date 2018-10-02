using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour {
    public Slider HealthSlider;
    public Text healthText;
    public int health = 10;
    float timer = 0.0f;
     void Start()
    {
        HealthSlider.GetComponent<Slider>().value = health;
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
        }
        if (health <= 0)
        {
            //reload level
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
        }
        if (health <= 0)
        {
            //reload level
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
        }
    }
}
