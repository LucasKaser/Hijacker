using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHP : MonoBehaviour
{

    public int health = 10;
    public AudioClip soundToPlay;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health--;
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}