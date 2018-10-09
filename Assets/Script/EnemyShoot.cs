using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float bulletLife;
    public float bulletSpeed;
    public float fireSpeed;
    float timer = 0;
    public GameObject prefab;
    public GameObject player1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer > fireSpeed)
        {
            timer = 0;

            Vector3 playerPosition = player1.transform.position;
            playerPosition = Camera.main.ScreenToWorldPoint(playerPosition);
            playerPosition.z = 0;
            Vector3 shootDir = playerPosition - transform.position;
            shootDir.Normalize();
            shootDir *= bulletSpeed;
            //destination - start pos.
            GameObject bullet = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir.normalized * bulletSpeed;
            Destroy(bullet, bulletLife);

        }
    }
}
