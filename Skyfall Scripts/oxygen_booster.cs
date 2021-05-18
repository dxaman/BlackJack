using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygen_booster : MonoBehaviour
{
    public GameObject pickupEffect;
	public AudioSource refill;

    void OnTriggerEnter (Collider other)
    {
    	if (other.CompareTag("Player"))
    	{
			Instantiate(pickupEffect, transform.position, transform.rotation);
		refill.Play();

    	player_oxygen stats = other.GetComponent<player_oxygen>();
    	stats.currentHealth+=500;

    	Destroy(gameObject);
    		//Pickup(other);
    	}
    }

    void Pickup(Collider player)
    {
    	Instantiate(pickupEffect, transform.position, transform.rotation);
		refill.Play();

    	player_oxygen stats = player.GetComponent<player_oxygen>();
    	stats.currentHealth+=500;

    	Destroy(gameObject);
    }
}
