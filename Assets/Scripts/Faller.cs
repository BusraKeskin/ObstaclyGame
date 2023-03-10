using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faller : MonoBehaviour
{
    
    float waitTime = 5f;
    Rigidbody rb;
    MeshRenderer renderer;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Time.time > waitTime)
        {
            rb.useGravity = true;
            renderer.enabled = true;

        }
    }
}
