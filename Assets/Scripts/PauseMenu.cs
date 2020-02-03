using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public string mainMenu;
    public string Game;
    private bool isPaused;
    public GameObject pauseMenuCanvas;


    // Update is called once per frame
    void Update () {
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
            
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
           
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
	}
    public void Pause()
    {
        isPaused = true;
        
    }
    public void Resume()
    {
        isPaused = false;
       
    }
    public void Restart()
    {
        Application.LoadLevel(Game);
    }
    public void Quit()
    {
        Application.LoadLevel(mainMenu);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
