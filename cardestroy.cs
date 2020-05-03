using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardestroy : MonoBehaviour
{
    public uiManager ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D collide)//Once a collision occurs destroy the car object
    {
        if(collide.gameObject.tag == "Enemy car")
        {
            
            gameObject.SetActive(false);
            ui.gameover();
        }
    }
}
