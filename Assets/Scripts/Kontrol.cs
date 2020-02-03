using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontrol : MonoBehaviour{
    public GameObject solKose;
    public GameObject sagKose;
    public GameObject platform;
  
   // private Rigidbody2D rg;
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
       // rg = GetComponent<Rigidbody2D>();
    }
    float speed = 1500f;
    void Update()
    {
        Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.x;


        var pos = transform.position;
        pos.x=Mathf.Clamp(dir.x,-2.60f,2.60f);
        transform.position = pos;
      //  transform.Translate();
     //   rg.AddForce(dir * speed*Time.deltaTime);
        
        
        
        /*  if (platform.transform.position==solKose.transform.position)
        {
            platform.transform.position = sagKose.transform.position;
        }*/
        
    }
}
