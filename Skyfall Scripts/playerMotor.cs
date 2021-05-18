using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class playerMotor : MonoBehaviour
{
    CharacterController controller;
    Vector3 moveVector;
    float speed = 2.0f;
    public bool isDead = false;
    public Transform target;
    public GameObject pickupEffect;
    public GameObject player;
     private float zatstart = 0;
     private float xatstart = 0;
     // Start is called before the first frame update
     void Start()
    {
        calib();
        controller=GetComponent<CharacterController>();
        
        
         
         
        
        
    }
     void calib(){
             xatstart = Input.acceleration.x;
             zatstart = Input.acceleration.y;
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
        moveVector.x=(Input.acceleration.x-xatstart)*speed*2;
        moveVector.y=(Input.acceleration.y-zatstart)*speed*2;
            
       //moveVector.x=Input.GetAxisRaw("Horizontal")*speed/3;
        
        //moveVector.y=Input.GetAxisRaw("Vertical")*speed/3;
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
   
    public void Death()
    {
        isDead = true;
        Instantiate(pickupEffect, transform.position, transform.rotation);
        Destroy(player);
        GetComponent<Score>().OnDeath();
    }
}
