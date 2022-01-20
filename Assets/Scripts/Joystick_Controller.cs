using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Joystick_Controller : MonoBehaviour
{
    public bool isDead;
    public float horizontal;
    public float speed;

    public Admin adminScript;

    public Joystick jy;

    public AudioSource soundEffect;

    float dirX;
    float gyroscopeSpeed = 5f;

    

    void Start(){
        soundEffect = GetComponent<AudioSource>();
        Debug.Log("Control: " + PlayerPrefs.GetString("control"));

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(PlayerPrefs.GetString("control") == "Joystick"){
            Debug.Log("Here is Working.");

            horizontal = jy.Horizontal;

            transform.up = new Vector3(horizontal * speed,0, 0);
            transform.Translate(new Vector3(horizontal, 0, 0) * speed * Time.deltaTime, Space.World);
            
        }

        if(transform.position.y < -2){

            SceneManager.LoadScene(0);

            isDead=true;
        }
    }

    void Update(){
        if(PlayerPrefs.GetString("control") == "Gyroscope"){
            dirX = Input.acceleration.x * speed;

            transform.up = new Vector3(dirX * speed,0, 0);
            transform.Translate(new Vector3(dirX, 0, 0) * speed * Time.deltaTime, Space.World);
            

        }

    }

     void OnCollisionEnter2D(Collision2D collision) {
        soundEffect.Play();
     }
     
}
