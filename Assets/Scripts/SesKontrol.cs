using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SesKontrol : MonoBehaviour {

    public static AudioSource sesDosyasi;
    public Slider mainSlider;
    public AudioClip song;
    // Use this for initialization
    void Start () {
        sesDosyasi = this.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        sesDosyasi.volume = PlayerPrefs.GetFloat("SonSes");
        
    }
    public void SesAyarla(float value)
    {
        PlayerPrefs.SetFloat("SonSes", value);
    }
    public void SesDevam()
    {
      
        
            sesDosyasi.clip = song;
            sesDosyasi.Play(0);
            
        
    }
    public void SesDurdur()
    {
     
            sesDosyasi.Pause();
            
        
    }
}
