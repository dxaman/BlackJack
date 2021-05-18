using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System;
using UnityEngine.SocialPlatforms;


public class PlayGamesController : MonoBehaviour
{
    private static bool isAuthenticated = false;
    public static PlayGamesPlatform platform;
    void Start()
    {
       if(platform==null)
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled=true;
            platform = PlayGamesPlatform.Activate();
        }
        Social.Active.localUser.Authenticate(success=>{ 
            if (success)
            {
                isAuthenticated = true;
            }
            else
            {
                isAuthenticated = false;
            }
        });
        /*DontDestroyOnLoad(this);
        try
        {
             PlayGamesClientConfiguration config = new      PlayGamesClientConfiguration.Builder().Build();
             PlayGamesPlatform.InitializeInstance(config);
             PlayGamesPlatform.DebugLogEnabled = true;
             PlayGamesPlatform.Activate();
             Social.localUser.Authenticate((bool success) =>{ });
        }
        catch (Exception ex)
        {
             Debug.Log( ex.InnerException);
        }*/
 }
public void AddScoreToLeaderBoard(string leaderBoard, int score)
 {
     if (Social.localUser.authenticated)
     {
         Social.ReportScore(score, leaderBoard, success => { });
     }
 }
public void ShowLeaderBoard()
 {
      if (Social.localUser.authenticated)
     {
          Social.ShowLeaderboardUI();
     }
 }
}
