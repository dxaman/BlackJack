using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotAcce : MonoBehaviour
{
    // Start is called before the first frame update
  Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;
    Vector3 desiredDir;
    
    Rigidbody m_Rigidbody;
    
    public float turnSpeed = 20f;
    public float zCompOfRotVect;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        m_Rigidbody = GetComponent<Rigidbody>();
       
        
    }
     

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.acceleration.x;
        float vertical = Input.acceleration.y;

        m_Movement.Set(horizontal, vertical, 0f);
        m_Movement.Normalize();

        desiredDir.Set(-horizontal, -vertical, zCompOfRotVect);

        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, desiredDir, turnSpeed * Time.deltaTime, 0f);
        m_Rotation = Quaternion.LookRotation(desiredForward);


    }
    void OnAnimatorMove ()
    {
        m_Rigidbody.MoveRotation(m_Rotation);
    }
}
