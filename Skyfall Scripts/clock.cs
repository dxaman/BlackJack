using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject pickupEffect;
	public AudioSource refill;
    public slow timeSlower;
    public GameObject des;

    void OnTriggerEnter (Collider other)
    {
    	if (other.CompareTag("Player"))
    	{
    		Pickup(other);
    	}
    }

    void Pickup(Collider player)
    {
    	Instantiate(pickupEffect, transform.position, transform.rotation);
		refill.Play();

    	 timeSlower.DoSlowmotion();

    	Destroy(des);
    }
}
