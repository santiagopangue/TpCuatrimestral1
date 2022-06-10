using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroncoSpawner : MonoBehaviour
{
    public Transform spawnear;
    public GameObject tronco;
    GameObject clone;

    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        while (true)
        {
            clone = Instantiate(tronco, spawnear.transform.position, spawnear.transform.rotation);
            yield return new WaitForSeconds(3);
            Destroy(clone, 15);
        }
    }
}
