using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour

    
{
    public Text highScore;
   //public GameObject infoUI;
  //  public TextMeshProUGUI textArea;
    //public GameObject boostersUI;
    //public TextMeshProUGUI boostersText;
    


    void Start()
    {
        highScore.text = "Highscore : " + (int)PlayerPrefs.GetFloat("Highscore");
        //infoUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ToRules()
    {
        SceneManager.LoadScene("Story");
       // infoUI.SetActive(true);
       // boostersUI.SetActive(false);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GameRules()
    {
        SceneManager.LoadScene("GameRules");
       // boostersUI.SetActive(false);
       // textArea.alignment = TextAlignmentOptions.Left;
        //textArea.text = "1. If player collides with obstacles like asteroid, meteors, meteorite, comets and planets then he will die and game ends.\n2.Try to collect boosters.They will help in various ways in game.\n3.Score increases as long as the player survives.\n4.Keep your device flat and tilt to move player left or right.\n5.Stay away from side walls else the player will die due to powerfull force fields running along the walls.\n6.Keep track of oxygen level because it is must for the playerto survive.";
    }

    public void Story()
    {
        SceneManager.LoadScene("Story");
       // boostersUI.SetActive(false);
        //textArea.alignment = TextAlignmentOptions.Center;
       // textArea.text = "An astronaut was returning to the earth after finishing the mission. Unfortunately, on the way engines of the spacecraft stopped functioning and it entered an untracked path. He realizes that the spacecraft will crash and it is out of control. He decides to leave it and jump into the space. He believes that his spacesuit would protect him and he will land safely.But on route there are various obstacles.He needs your help!!";
    }

    public void Boosters()
    {
        SceneManager.LoadScene("Boosters");
        //textArea.text = "";
      // boostersUI.SetActive(true);
       // boostersText.text = "Shield- It will protect the player when  he collides with obstacles or sidewalls.\n\n\nCoin(+50) - It will increase your score instantly by 50 points.\n\n\nOxygen tank-It will refill your oxygen bar.\n\n\nClock - It will slow down the time i.e.everyone's speed will drop thus becomes easier for you to dodge obstacles";
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
       // infoUI.SetActive(false);
      // boostersUI.SetActive(false);
       // textArea.text = "";
    }
}
