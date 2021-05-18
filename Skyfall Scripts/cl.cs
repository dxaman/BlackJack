using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cl : MonoBehaviour
{
    // Start is called before the first frame update
    //public AudioSource CollectSound;
   // public Transform player; 
    public AudioSource Clock;
    public slow timeSlower;
    
    void OnTriggerEnter(Collider other)
    {
         
       // if (other.transform == player)
        if (other.CompareTag("Player"))
        
        {
            //CollectSound.Play();
            
            timeSlower.DoSlowmotion();
            Clock.Play();
            Destroy(gameObject);
        }
        
    }
}
