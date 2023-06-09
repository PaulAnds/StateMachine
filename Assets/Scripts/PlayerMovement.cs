using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed;
    public Rigidbody2D rb;

    private Vector2 moveDirection;

    // Update is called once per frame
    void Update(){
        ProcessInput();
    }

    private void FixedUpdate() {
        Move();
    }

    void ProcessInput(){
        float moveX =Input.GetAxisRaw("Horizontal");
        float moveY =Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX,moveY).normalized;
    }

    void Move(){
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }
}
