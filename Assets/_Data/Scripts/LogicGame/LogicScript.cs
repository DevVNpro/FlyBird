using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Text scoreText;
    public Text hightScore;
    public int playerScore;
    public int saveScore = 0;
    private void Start()
    {
        hightScore.text = LoadScore().ToString();

    }
    public void AddScore()
    {
        playerScore +=  1;
        saveScore += 1; 
        scoreText.text = playerScore.ToString();
        SoundManager.Instance.PlayVFXMusic("vfx1");

    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        if(playerScore > LoadScore()) { 
            SaveScore(playerScore);
        }
    }
    public  void SaveScore(int score) 
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();
 
    }
    public  int LoadScore() 
    {
        return PlayerPrefs.GetInt("score",0);
    }

  
    public void ResetScore()
    {
        SaveScore(0);
    }

}
