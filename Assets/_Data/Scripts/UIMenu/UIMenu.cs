using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    [SerializeField] protected Button start;
    [SerializeField] protected Button quit;

    private void Start()
    {
        start.onClick.AddListener(PlayGame);
        quit.onClick.AddListener(QuitGame);

    }
    public void PlayGame()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
  

}
