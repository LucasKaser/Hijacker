using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PMCollisions : MonoBehaviour {
    public float timer = 0.0f;
    //this function runs once when a new collision begins
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I started a collision");
    }
    // this function runs every time we stay colliding
     void OnCollisionStay2D(Collision2D collision)
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            timer = 0;

            Debug.Log("I am continuing collide");
        }
        
    }
     void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("I have stopped colliding");
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("The trigger is triggered");
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("The trigger is still triggered");
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("The trigger is no longer triggered");
    }
}
