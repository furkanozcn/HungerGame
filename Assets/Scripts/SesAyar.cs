using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SesAyar : MonoBehaviour {
    Text text;
    public static string degerOn;
    public static string degerOff;
    void Start()
    {
        text = GetComponent<Text>();
        degerOn = "ON";
        degerOff = "OFF";
    }
    public void Update()
    {
        if (PlayerPrefs.GetFloat("SonSes") > 0)
            text.text = "" + degerOn;
        else if(PlayerPrefs.GetFloat("SonSes") == 0)
            text.text = "" + degerOff;

    }
    public void sesAyari()
    {
        if (PlayerPrefs.GetFloat("SonSes") > 0)
            PlayerPrefs.SetFloat("SonSes", 0f);
        else if (PlayerPrefs.GetFloat("SonSes") == 0)
            PlayerPrefs.SetFloat("SonSes", 1f);
    }
}
