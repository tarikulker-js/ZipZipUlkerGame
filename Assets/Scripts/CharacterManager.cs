using TMPro; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    public GameObject playerSkin;

    public TextMeshProUGUI characterName;

    
    public int selectedSkin = 0;

    void FixedUpdate(){
        if(selectedSkin == 0){
            characterName.text = "Büyücü Tarık";

        }else if(selectedSkin == 1){
            characterName.text = "Dızo Kağan";

        }else if(selectedSkin == 2){
            characterName.text = "Baby Face Keko Umut";

        }else if(selectedSkin == 3){
            characterName.text = "Çıtır Melike";

        }else if(selectedSkin == 4){
            characterName.text = "Eylül";

        }else if(selectedSkin == 5){
            characterName.text = "Aslan Bacı İrem";

        }else if(selectedSkin == 6){
            characterName.text = "Nefes Kesen Usta Ömer";

        }

    }
    
    public void NextOption(){
        selectedSkin = selectedSkin + 1;

        if(selectedSkin == skins.Count){
            selectedSkin = 0;

        }

        sr.sprite = skins[selectedSkin];

        
    }  

    public void BackOption(){
        selectedSkin = selectedSkin - 1;

        if(selectedSkin < 0){
            selectedSkin = 0;

        }

        sr.sprite = skins[selectedSkin];
        
        
    }

    public void Play(){
        PlayerPrefs.SetInt("SelectedCharacter", selectedSkin);
        Debug.Log("PlayerSkin" + selectedSkin);
        SceneManager.LoadScene(1);

    }

}
