using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBehaviour : StateMachineBehaviour
{

    float Delay;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Delay = 2f;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Revive
        Delay -= Time.deltaTime;
        
        if(Delay <= 0){
            
            animator.SetBool("isDead", false);
        }
        
    }
}
