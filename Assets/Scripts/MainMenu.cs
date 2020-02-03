using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public string startGame;
    public string exitGame;
   
    public void NewGame () {
        Application.LoadLevel(startGame);
	}
	
	
	public void QuitGame () {
        Application.Quit();
	}
}
