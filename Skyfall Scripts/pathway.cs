using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathway : MonoBehaviour
{
    private bool isDead = false;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //if (other.transform == player)
        if (other.CompareTag("Player"))
        {
            
            

        }
    }
}
