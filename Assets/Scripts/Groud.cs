using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Groud : MonoBehaviour
{
    public float JumpSpeed = 10;
    public bool touched, deleted;
    public float timer = 0.0f;
    
    void Start(){
        touched=false;
        

    }

    void Update(){
        if(touched==true){
            Destroy(gameObject, 2);
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        
        if(collision.relativeVelocity.y < 0){
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if(rb != null) {
                Vector2 jumpVelocity = rb.velocity;
                jumpVelocity.y = JumpSpeed;
                rb.velocity = jumpVelocity;

                if(!touched){
                    Admin.scoreNumber++;
                    touched=true;

                }

                

            }
        }
    }

}
