using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public float bulletLife;
    public float bulletSpeed;
    public float fireSpeed;
    float timer = 0;
    public GameObject prefab;
    public GameObject player1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
         
        if (timer > fireSpeed)
        {
            timer = 0;
            Vector3 playerPosition = player1.transform.position;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            shootDir *= bulletSpeed;
            //destination - start pos.
            GameObject bullet = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir.normalized * bulletSpeed;
            Destroy(bullet, bulletLife);

        }
	}
}
