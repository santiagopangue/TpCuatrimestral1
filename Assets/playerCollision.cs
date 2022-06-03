using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    float spawnX;
    float spawnY;
    float spawnZ;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnX = 0;
        spawnY = 1;
        spawnZ = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -3f)
        {
            transform.position = new Vector3(spawnX, spawnY, spawnZ);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Checkpoint 1")
        {
            spawnX = -23f;
            spawnY = 0.2f;
            spawnZ = -0.1f;
        }
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
