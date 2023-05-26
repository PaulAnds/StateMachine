using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviveBehaviour : StateMachineBehaviour
{
    float Delay;
    public Enemy enemy;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        enemy = FindObjectOfType<Enemy>();
        Delay = 2f;
        animator.SetBool("FinishRiviving", false);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
         //Revive
        Delay -= Time.deltaTime;
        
        if(Delay <= 0){
            animator.SetBool("FinishRiviving", true);
            
            if(enemy.isTrigger){
                animator.SetBool("isFollowing", true);
            }
            else if(!enemy.isTrigger){
                animator.SetBool("isFollowing", false);
            }
        }
    }

}
