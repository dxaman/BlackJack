using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotator : MonoBehaviour
{
     public Vector3 myPos;
     //public Transform myPlay;
     public Transform target;
     const float rotationAmount = 1.3f;
	private int cal=1;

     void Update()
     {
       if(cal>75){

	transform.position = target.position + myPos;
     if (target.position.z<4){

     
	transform.rotation=target.rotation;
     }
     }
	if(cal<90){
       transform.RotateAround(target.position, Vector3.up, rotationAmount);}
	cal=cal+1;
     }
      
      
     
}
