using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject buyucuSkin;
    public GameObject dizoSkin;
    public GameObject babyFaceKekoSkin;
    public GameObject citirMelikeSkin;
    public GameObject eylulSkin;
    public GameObject iremSkin;
    public GameObject nefesKesenUstaSkin;
    
    public GameObject Player;
    
    private Sprite playersprite;

    void Start()
    {

        //0 = Buyucu 1 = Dizo

        if(PlayerPrefs.GetInt("SelectedCharacter") == 0){
            playersprite = buyucuSkin.GetComponent<SpriteRenderer>().sprite;
            Player.GetComponent<SpriteRenderer>().sprite = playersprite;
            
        }else if(PlayerPrefs.GetInt("SelectedCharacter") == 1){
            playersprite = dizoSkin.GetComponent<SpriteRenderer>().sprite;
            Player.GetComponent<SpriteRenderer>().sprite = playersprite;
            
        }else if(PlayerPrefs.GetInt("SelectedCharacter") == 2){
            playersprite = babyFaceKekoSkin.GetComponent<SpriteRenderer>().sprite;
            Player.GetComponent<SpriteRenderer>().sprite = playersprite;
            
        }else if(PlayerPrefs.GetInt("SelectedCharacter") == 3){
            playersprite = citirMelikeSkin.GetComponent<SpriteRenderer>().sprite;
            Player.GetComponent<SpriteRenderer>().sprite = playersprite;
            
        }else if(PlayerPrefs.GetInt("SelectedCharacter") == 4){
            playersprite = eylulSkin.GetComponent<SpriteRenderer>().sprite;
            Player.GetComponent<SpriteRenderer>().sprite = playersprite;
            
        }else if(PlayerPrefs.GetInt("SelectedCharacter") == 5){
            playersprite = iremSkin.GetComponent<SpriteRenderer>().sprite;
            Player.GetComponent<SpriteRenderer>().sprite = playersprite;
            
        }else if(PlayerPrefs.GetInt("SelectedCharacter") == 6){
            playersprite = nefesKesenUstaSkin.GetComponent<SpriteRenderer>().sprite;
            Player.GetComponent<SpriteRenderer>().sprite = playersprite;
            
        }
        
        
        
    }

}
