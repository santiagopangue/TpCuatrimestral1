﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class botonReiniciar : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void reset()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
