using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class EnemyCarMove : MonoBehaviour
{
    public float speed = 7f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame moves the enemy car 
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        
    }
}
