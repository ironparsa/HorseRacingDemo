using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void mainGame()
    {
        Debug.Log("Switching to mainGame");
        string scene = SceneManager.GetActiveScene().name;
        if (scene == "mainGame")
        {
            GameObject.Find("PauseMenu").SetActive(false);
            Time.timeScale = 1f;
            PauseMenu.GameIsPaused = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        SceneManager.LoadScene("mainGame");
    }
    //switch to quit the game
    public void QuitGame() 
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
    

}
