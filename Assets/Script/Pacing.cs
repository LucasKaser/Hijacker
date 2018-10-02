using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacing : MonoBehaviour {
    public Vector3 PaceDirection = new Vector3(0, 0, 0);
    public float PaceDistance = 3.0f;
    public float movespeed = 3.0f;
    Vector3 startPosition;
	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        PaceDirection.Normalize();
        PaceDirection = PaceDirection * movespeed;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 displacement = transform.position - startPosition;
        float distance = displacement.magnitude;
        if (distance >= PaceDistance)
        {
            PaceDirection = -PaceDirection;
        }
        GetComponent<Rigidbody2D>().velocity = PaceDirection;
	}
}
