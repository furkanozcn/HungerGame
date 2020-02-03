using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour {

    public static int score;
    public static int highscore=0;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
        
    }
    void Update()
    {
        if (score < 0)
            score = 0;
           text.text = "" + score;
        if (Skor.score > PlayerPrefs.GetInt("Score"))
            PlayerPrefs.SetInt("Score", score);
       
    }
    public static void AddFruits(int pointsToAdd)
    {
        score += pointsToAdd;    
    }
    public static void Reset()
    {
        score = 0;
    }

}
