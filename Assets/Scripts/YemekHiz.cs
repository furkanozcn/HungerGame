using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YemekHiz : MonoBehaviour {

    public float hiz;
    public Rigidbody2D rg;
	// Use this for initialization
	void Start () {
        rg = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rg.velocity = new Vector2(0, -hiz * Time.deltaTime);
	}
}
