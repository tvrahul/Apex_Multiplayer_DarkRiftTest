using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChar : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime,0);
    }
}
