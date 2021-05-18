using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
       scoreText.text = GetComponent<Score>().score.ToString("0"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
