using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastSkor : MonoBehaviour {
    Text text;

    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        text.text = "" + Skor.score;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
