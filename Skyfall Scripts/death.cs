﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
{
	
	if (gameObject.tag=="obstacle")
	{
		Application.Quit();
	}
}
}
