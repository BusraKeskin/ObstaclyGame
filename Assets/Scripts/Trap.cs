using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] float xRot = 0f;
    [SerializeField] float yRot = 0f;
    [SerializeField] float zRot = 0f;
    void Update()
    {
        transform.Rotate(1, yRot, zRot);
    }
}
