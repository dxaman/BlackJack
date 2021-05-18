using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class playerM : MonoBehaviour
{
    CharacterController controller;
    Vector3 moveVector;
    float speed = 2.0f;
    private bool isDead = false;
    private float startTime;
    private float animationDuration = 3.0f;
    public Transform target;
    
    


    // Start is called before the first frame update
     void Start()
    {
        controller=GetComponent<CharacterController>();
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
            return;

      /*  if (Time.time - startTime < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }*/

        moveVector=Vector3.zero;

       
        
        if(target.position.z>3.5f){
            speed=10.0f;
        moveVector.x=Input.GetAxisRaw("Horizontal")*speed/3;
        
        moveVector.y=Input.GetAxisRaw("Vertical")*speed/3;
        }
        
        moveVector.z=speed;
        controller.Move(moveVector*Time.deltaTime);

      
    }
    public void SetSpeed(float modifier)
    {
        speed = 10.0f+modifier;
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (gameObject.tag=="cube")
        {
            return;
        }
        if ((hit.point.z > transform.position.z)) //&& ((CountdownTimer.temp%2)!=0) )
        {
            Death();
        }
        
    }
    private void Death()
    {
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
}
