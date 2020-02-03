using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    
    Text text;
	// Use this for initialization
	void Start () {
        
        text = GetComponent<Text>();
        text.text = PlayerPrefs.GetInt("Score").ToString();
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
