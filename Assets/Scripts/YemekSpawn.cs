using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YemekSpawn : MonoBehaviour
{
    public GameObject[] prefabs;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Olustur", 0.1f, 0.5f);
    }
 
        void Olustur()
        {
        float salla = Random.Range(0, prefabs.Length);
        Vector3 position = new Vector3(Random.Range(-2.61f, 2.60f),7);
        var x = Instantiate(prefabs[(int)salla], position, Quaternion.identity);
        x.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 1, 0);
    }
    
}
