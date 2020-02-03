using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YemekYeme : MonoBehaviour {

    public AudioClip EatSound;
    void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.GetComponent<Kontrol>() == null)
            return;

        if (PlayerPrefs.GetFloat("SonSes") != 0f)
            AudioSource.PlayClipAtPoint(EatSound, nesne.gameObject.transform.position);

    }
}
