using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class uiManager : MonoBehaviour
{
    int score;
    public Text scoreText;

    public Button[] buttons;
   
    bool game;

    // Start is called before the first frame update
    void Start()
    {
        game = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.40f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
       
    }

    void scoreUpdate()//Function to update score
    {
        if (game == false)
        {
            score = score + 1;
        }
    }
   

    public void gameover()//Activate the hidden buttons once the game is over 
    {
        game = true;
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
            
        }
    }


    public void play()//Activate the game once the user clicks the player 1 button
    {

        SceneManager.LoadScene("level1");
    }

    public void pause()// Pause the game once the player clicks the pause button
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
    }

   
    public void menu()//Load the menu scene once the player clicks the menu button
    {
        SceneManager.LoadScene("menu");
    }

    


}
