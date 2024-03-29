﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(ball, transform.position,transform.rotation);
        InvokeRepeating("SpawnBall", 0f, 1f);
    }

    void SpawnBall()
    {
        Vector3 posVec = new Vector3(Random.Range(-5f,5f),transform.position.y,transform.position.z);
        Instantiate(ball, posVec,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
