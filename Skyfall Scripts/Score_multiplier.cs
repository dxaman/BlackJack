using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_multiplier : MonoBehaviour
{
    public GameObject pickupEffect;
    public float duration = 5f;
	public AudioSource coin;

    void OnTriggerEnter (Collider other)
    {
    	if (other.CompareTag("Player"))
    	{
    		StartCoroutine( Pickup(other) );
    	}
    }

    IEnumerator Pickup(Collider player)
    {
    	Instantiate(pickupEffect, transform.position, transform.rotation);
		coin.Play();

    	Score obj1 = player.GetComponent<Score>();
    	obj1.score+=50;

    	GetComponent<MeshRenderer>().enabled=false;
    	GetComponent<Collider>().enabled=false;

    	yield return new WaitForSeconds(duration);

    	Destroy(gameObject);
    }
}
