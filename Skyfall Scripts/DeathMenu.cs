using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Reflection;
using System;

using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class DeathMenu : MonoBehaviour
{
    public Text scoreText;
    public Image backgroundImg;
    private bool isShown = false;
    private float transition = 0.0f;
    public playerMotor playerMotor;
    
    public AudioSource deathAudio;
    bool m_HasAudioPlayed;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShown)
        {
            return;
        }

        transition += Time.deltaTime;
        //backgroundImg.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, transition);
    }
    
    
        
    public void ToggleEndMenu(float score)
    {
        if (!m_HasAudioPlayed)
        {
            deathAudio.Play();
            m_HasAudioPlayed = true;
        }

        gameObject.SetActive(true);
        scoreText.text = ((int)score).ToString();
        isShown = true;
            playerMotor.isDead = true;
       
    }


        
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ShowLead()
    {
        Social.ShowLeaderboardUI();
    }
}
