using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    [SerializeField]  protected Button restartGame;
    [SerializeField] protected Button backToMenu;
    private void Start()
    {
        restartGame.onClick.AddListener(RestartGame);
        backToMenu.onClick.AddListener(BackToMenu);

    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
  
}
