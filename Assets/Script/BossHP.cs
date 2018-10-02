using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BossHP : MonoBehaviour
{
    public GameObject Door;
    public int health = 500;

    public Slider HealthSlider;
    
    void Start()
    {
        HealthSlider.GetComponent<Slider>().value = health;
        
    }
        void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            health--;
            HealthSlider.GetComponent<Slider>().value = health;
        }
        if (health <= 0)
        {
            gameObject.SetActive(false);
            Door.SetActive(false);
        }
    }
}