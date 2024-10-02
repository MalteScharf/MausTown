using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Timeline;

public class Movement : MonoBehaviour
{   
    public float speed;
    private UnityEngine.Vector3 direction;
    public Animator animator; 
    

    private void Update(){

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");


        direction = new UnityEngine.Vector3(horizontal,vertical);
        AnimateMovement(direction);

    }

    private void FixedUpdate(){
        this.transform.position += direction.normalized * speed * Time.deltaTime;

    }

    void AnimateMovement(UnityEngine.Vector3 direction){

        if (animator != null){
            if(direction.magnitude > 0)
            {
                animator.SetBool("isMoving", true);
                animator.SetFloat("horizontal", direction.x);
                animator.SetFloat("vertical", direction.y);
                Debug.Log("Moving");
            }

            else 
            {
                animator.SetBool("isMoving", false);
            }
        }
    }
    
}
