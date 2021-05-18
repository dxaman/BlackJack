using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject pickupEffect;
    bool m_IsPlayerCaught;
    
    void OnTriggerEnter (Collider other)
    {
        if (gameObject.tag == "obstacle")
        {
            m_IsPlayerCaught = true;
        }
		else 
		{
			m_IsPlayerCaught = true;
		}
    }
  
    void Update ()
    {
        if(m_IsPlayerCaught)
        {
        	if((CountdownTimer.temp%2)==50)
            //SceneManager.LoadScene(0)
            ;
            else
            {
            	if (gameObject.tag == "obstacle")
            	{
            		Instantiate(pickupEffect, transform.position, transform.rotation);
            		
            	}
            }
        }
	m_IsPlayerCaught= false;
    }
}
