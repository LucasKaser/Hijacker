using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour {
    public GameObject player;
    public AudioClip soundToPlay;
    public float chaseSpeed = 3.0f;
    public float chaseTriggerDistance = 3.0f;
    public Vector3 paceDirection = new Vector3(0, 0, 0);
    public float paceDistance = 3.0f;
    public float paceSpeed = 3.0f;
    Vector3 startPosition;
    bool home = true;
    public float bulletLife;
    public float bulletSpeed;
    public float fireSpeed;
    float timer = 0;
    public GameObject prefab;
    public GameObject player1;
    // Use this for initialization
    void Start () {
        startPosition = transform.position;
        player = GameObject.FindGameObjectWithTag("player");

	}

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        Vector3 playerPosition = player.transform.position;
        Vector3 chaseDirection = playerPosition - transform.position;
        if (chaseDirection.magnitude < chaseTriggerDistance)
        {
            //chase the player
            Debug.Log("chase");
            home = false;
            chaseDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;
            if (timer > fireSpeed)
            {
                Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
                timer = 0;
                
                playerPosition.z = 0;
                Vector2 vel = player.GetComponent<Rigidbody2D>().velocity;
                Vector3 vel2 = new Vector3(vel.x, vel.y, 0);
                Vector3 shootDir = playerPosition - transform.position + vel2;
                shootDir.Normalize();
                shootDir *= bulletSpeed;
                //destination - start pos.
                GameObject bullet = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = shootDir.normalized * bulletSpeed;
                Destroy(bullet, bulletLife);
            }

        }
        else if (home == false)
        {
            Debug.Log("go home?");
            Vector3 homeDirection = startPosition - transform.position;
            //homeDirection.Normalize();
            if (homeDirection.magnitude < 1.0f)
            {
                Debug.Log("I am home");
                home = true;
                transform.position = startPosition;
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);

            }
            else
            {
                //go home
                Debug.Log("go home");
                homeDirection.Normalize();
                GetComponent<Rigidbody2D>().velocity = homeDirection * paceSpeed;
            }
            
        }
        else
        {
            Debug.Log("pace");
            Vector3 displacement = transform.position - startPosition;
            float distanceFromStart = displacement.magnitude;
            if (distanceFromStart >= paceDistance)
            {
                paceDirection = -paceDirection;
            }
            paceDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = paceDirection * paceSpeed;
        }

    }
}
