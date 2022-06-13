using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentiladorRotation : MonoBehaviour
{

    float rotationspeed = 2.5f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationspeed);
    }
}
