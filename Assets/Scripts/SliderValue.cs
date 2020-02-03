using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour {

    public Slider mainSlider;
    void Start()
    {
        mainSlider.value = PlayerPrefs.GetFloat("SonSes");
    }
}
