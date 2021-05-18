using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System;
using UnityEngine.SocialPlatforms;

public class Score : MonoBehaviour
{
    public float score = 0.0f;
    public Text scoreText;
    public Text NHS;
    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 100;
    private int scoreToNextLevel = 10;
    private bool isDead = false;
    public DeathMenu deathMenu;
    public string lead;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
            return;

        if(score >= scoreToNextLevel)
        {
            LevelUp();
        }
        //score+=0.09f;
    	
        score += Time.deltaTime*difficultyLevel;
        scoreText.text = "Score : " + score.ToString("0");
        //scoreText.text = ((int)score).ToString();
    }

    void LevelUp()
    {
        if(difficultyLevel == maxDifficultyLevel)
        {
            return;
        }
        scoreToNextLevel *= 2;
        difficultyLevel++;
        GetComponent<playerMotor>().SetSpeed(difficultyLevel);
    }
    public void AddScoreToLeaderBoard(string leaderBoard, int score)
 {
     if (Social.localUser.authenticated)
     {
         Social.ReportScore(score, leaderBoard, success => { });
     }
 }

    public void OnDeath()
    {
        isDead = true;
        //deathMenu.ToggleEndMenu(score);
         if ((int)PlayerPrefs.GetFloat("Highscore") < score)
        {
            NHS.text = "NEW HIGH SCORE!!";
           
            PlayerPrefs.SetFloat("Highscore", score);
            
            
        }
        deathMenu.ToggleEndMenu(score);
        AddScoreToLeaderBoard(lead,(int)score);
    }
}
