using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public float baslangicZamani;
    private Text timer;
    public GameObject EndScreen;
	// Use this for initialization
	void Start () {
        timer = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        baslangicZamani -= Time.deltaTime;
       
        if (baslangicZamani <= 0)
        {
            EndScreen.SetActive(true);
            Time.timeScale = 0f;
        }
        timer.text = "" + Mathf.Round(baslangicZamani);
    }
}
