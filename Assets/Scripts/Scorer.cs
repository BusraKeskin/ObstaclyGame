using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hited")
        {
            hitCount += 1;
            Debug.Log("You hit that wall many times:" + hitCount);
        }
        
    }
}
