using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class ControlSettings : MonoBehaviour
{
    ToggleGroup toggleGroupInstance;

    public Toggle selectedControl{
        get{
            return toggleGroupInstance.ActiveToggles ().FirstOrDefault();
        }
    }
    void Start()
    {
        toggleGroupInstance = GetComponent<ToggleGroup> ();
        Debug.Log("First Selected: " + selectedControl);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetString("control") != selectedControl.name){
            PlayerPrefs.SetString("control", selectedControl.name);
            Debug.Log("Değiştirildi. Yeni Kontrol: " + PlayerPrefs.GetString("control"));

        }
    }
}
