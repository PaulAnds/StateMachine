using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isTrigger = false;
    public bool isCollision = false;


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            isTrigger = true;            
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player"){
            isTrigger = false;            
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            isCollision = true;            
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            isCollision = false;            
        }
    }
}
