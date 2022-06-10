using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "PisoChicoTrampa1")
        {
            transform.position = new Vector3(0f, 1f, 0f);
        }
   
        if (col.gameObject.name == "PisoChicoTrampa2")
        {
            transform.position = new Vector3(0f, 1f, 0f);
        }
    }
}
