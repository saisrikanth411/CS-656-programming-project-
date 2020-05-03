using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System.Timers;

public class trackmove : MonoBehaviour
{

    public float speed;

    Vector2 offset;

    float delay = 2.5f;

    float time;

    int i = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        time = delay;
        
    }

    // Update is called once per frame. 
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            offset = new Vector2(0, Time.time * speed* i);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
            
        }
        i = i + 1;


    }

    
}
