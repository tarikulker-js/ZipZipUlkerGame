using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Router : MonoBehaviour
{
    public TextMeshProUGUI highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("_highScore").ToString();

    }

    public void startGame() {
        SceneManager.LoadScene(1);
    }

    public void exitGame() {
        Application.Quit();
        
    }

    public void settings() {
        SceneManager.LoadScene(2);
    }

    public void chooseCharacter() {
        SceneManager.LoadScene(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
