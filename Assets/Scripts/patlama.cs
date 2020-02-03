using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlama : MonoBehaviour {

    public AudioClip BoomSound;
    public GameObject patla;
    void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.GetComponent<Kontrol>() == null)
            return;

        Instantiate(patla, nesne.gameObject.transform.position, Quaternion.identity);
        if(PlayerPrefs.GetFloat("SonSes")!=0f)
            AudioSource.PlayClipAtPoint(BoomSound, nesne.gameObject.transform.position);
            

        
    }
}
