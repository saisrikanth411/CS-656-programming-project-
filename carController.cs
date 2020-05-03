using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class carController : MonoBehaviour
{
    Rigidbody2D rigid;

    public float carSpeed;
    
    public float maxPos = 2.3f;
    Vector3 position;

    public uiManager ui;

    bool android_platform;

    void Awake()
    {

        rigid = GetComponent<Rigidbody2D>(); 
#if UNITY_ANDROID
        android_platform =  true;
#else
        android_platform = false;
#endif
    }

    // Start is called before the first frame update
    void Start()
    {
       
        position = transform.position;
        if(android_platform == true)
        {
            Debug.Log("android platform");
        }
        else
        {
            Debug.Log("not android platform");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (android_platform == true)
        {
            position = transform.position;
            position.x = Mathf.Clamp(position.x, -2.3f, 2.3f);
            transform.position = position;
        }
        else
        {
            position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
            position.x = Mathf.Clamp(position.x, -2.3f, 2.3f);
            transform.position = position;
        }
        
    }

    void OnCollisionEnter2D(Collision2D collide)//Once a collision occurs destroy the car object
    {
        if(collide.gameObject.tag == "Enemy car")
        {
            gameObject.SetActive(false);
            ui.gameover();
        }
    }

    public void speed_zero()//Sets the speed of the car to zero 
    {

        rigid.velocity = new Vector2(0, 0);
    }

    public void left_move()// Moves the car in the left direction
    {
        rigid.velocity = new Vector2(-carSpeed, 0);

    }

    public void right_move()//Moves the car in the right direction
    {
        rigid.velocity = new Vector2(carSpeed, 0);
    }

    

}
