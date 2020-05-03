using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class carSpawner : MonoBehaviour
{
    

    public GameObject[] cars;
    int max = 3;
    int min = 0;
    
    public float maxPos = 2.3f;

    public float delay = 0.5f;

    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = delay;
    }

    // Update is called once per frame . Instantiate enemy cars by spawning them from between the edges of the screen.
    
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
                Vector3 car_position = new Vector3(Random.Range(-maxPos, maxPos), transform.position.y, transform.position.z);
            
                Instantiate(cars[Random.Range(min,max)], car_position, transform.rotation);
                time = delay;
            
        }

        
    
        
    }
    
}
