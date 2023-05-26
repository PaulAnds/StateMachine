using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBehaviour : StateMachineBehaviour
{

    public PlayerMovement player;
    public float speed;
    public Enemy enemy;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        enemy = FindObjectOfType<Enemy>();
        player = FindObjectOfType<PlayerMovement>();
    }

     //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.position = Vector2.MoveTowards(animator.transform.position,player.transform.position,speed * Time.deltaTime);
        
        //Switch to exit collisions on seen radius
        if(!enemy.isTrigger){
            animator.SetBool("isFollowing", false);
        }     

        //if player hits they die
        if(Input.GetKeyDown(KeyCode.Space) && enemy.isCollision){
            animator.SetBool("isDead", true);
        }     
    }

}
