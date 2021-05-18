using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float startingTime=0;
    public static int cal=0;
    public static int temp=0;

    public Text CountdownText;
    void Update()
    {
	if(startingTime==0){temp=(2*temp)+1;}
        if (gameObject.tag == "shield"){
            transform.Rotate(0,4,0,Space.World);
        }
	if ((startingTime<0.5) && (gameObject.tag == "shield")){
	startingTime=5f;
	boosters.num += 1;
	}	
	if ((cal==boosters.num) && startingTime>0)
	{
	temp=2*temp;
        startingTime -= 1 * Time.deltaTime;
        CountdownText.text = "TIMER:" + startingTime.ToString ("0");
	if(startingTime>=3.5f){CountdownText.color = Color.green;}
        if(startingTime<3.5f){CountdownText.color = Color.red;}
	}
        
    }
}
