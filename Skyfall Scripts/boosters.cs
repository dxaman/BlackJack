using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boosters : MonoBehaviour
{
    //public AudioSource collectSound;
	public static int num =1;

   private void OnTriggerEnter(Collider other)
{
	
	if (gameObject.tag=="shield")
	{
	CountdownTimer.cal=num;
	Destroy(gameObject);
	}
	//num=num+1;
}
   
}
