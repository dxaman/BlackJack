using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerometer : MonoBehaviour
{
    // Start is called before the first frame update
 CharacterController controller;
    Vector3 moveVector;
    float speed = 2.0f;
    public bool isDead = false;
    public Transform target;
    Vector3 calibratedtilt = Vector3.zero;
    
     // Start is called before the first frame update
     void Start()
    {
        controller=GetComponent<CharacterController>();
         
         
        
        
    }
     public void Calibrate()
     {
         //Gets devices physical rotation in 3D space
         calibratedtilt.x = Input.acceleration.x;
         calibratedtilt.z = 0;
         calibratedtilt.y = Input.acceleration.y;
     }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;
        }

       
         if(target.position.z>3.0f && target.position.z<6.0f){
             speed =10.0f;
         }

        if(target.position.z>3.0f){
            
         moveVector.x=(Input.acceleration.x-calibratedtilt.x)*speed*2;
        moveVector.y=(Input.acceleration.y-calibratedtilt.y)*speed*2;
        }
        moveVector.z = speed;

       /* if ((-9.7 >= transform.position.x) || transform.position.x >= 9.7)
        {
            moveVector.x = 0;
        }
        if ((-9.7 >= transform.position.y) || transform.position.y >= 9.7)
        {
            moveVector.y = 0;
        }*/
        

       
        controller.Move(moveVector * Time.deltaTime);
    }
    public void SetSpeed(float modifier)
    {
        speed = 10.0f + modifier;
    }
   
    public void Death()
    {
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
}