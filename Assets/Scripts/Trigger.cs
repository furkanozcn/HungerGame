using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public int pointsToAdd;
    void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.GetComponent<Kontrol>() == null)
            return;

        Skor.AddFruits(pointsToAdd);

        Destroy(gameObject);
    }
}
