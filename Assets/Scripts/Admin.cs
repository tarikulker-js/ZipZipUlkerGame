using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Admin : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static int scoreNumber = 0;
    public bool pausedGame;
    public Joystick_Controller character;

    void Start()
    {

    }

    public void pauseGame(){
        if(pausedGame == false){
            Time.timeScale = 0f;
            pausedGame=true;
            
        }else{
            Time.timeScale = 1f;
            pausedGame=false;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreNumber > PlayerPrefs.GetInt("_highScore")){
            PlayerPrefs.SetInt("_highScore", scoreNumber);
        }

        score.text = scoreNumber.ToString();

        if(character.isDead == true){
            scoreNumber = -1;

        }

    }
}
