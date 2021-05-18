using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot : MonoBehaviour
{
    // Start is called before the first frame update
   Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;
    Vector3 desiredDir;
    
    Rigidbody m_Rigidbody;
    
    public float turnSpeed = 20f;
    public float zCompOfRotVect;
    public Transform target;
     private float zatstart = 0;
     private float xatstart = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        calib();
        
        m_Rigidbody = GetComponent<Rigidbody>();
       
        
       
        
    }
     void calib(){
             xatstart = Input.acceleration.x;
             zatstart = Input.acceleration.y;
         }

    // Update is called once per frame
    void Update()
    {
       float horizontal = Input.acceleration.x-xatstart;
        float vertical = Input.acceleration.y-zatstart;
    
        //float horizontal = Input.GetAxis("Horizontal");
       // float vertical = Input.GetAxis("Vertical");
        

        m_Movement.Set(horizontal, vertical, 0f);
        m_Movement.Normalize();

        desiredDir.Set(-horizontal, -vertical, zCompOfRotVect);
        if(target.position.z>4.5){
        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, desiredDir, turnSpeed * Time.deltaTime, 0f);
        m_Rotation = Quaternion.LookRotation(desiredForward);
        }


    }
    void OnAnimatorMove ()
    {
        m_Rigidbody.MoveRotation(m_Rotation);
    }
}
