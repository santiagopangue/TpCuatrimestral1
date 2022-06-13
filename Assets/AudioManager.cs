using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource fuente;
    public AudioClip salto;
    public AudioClip muerte;
    public AudioClip ganaste;
    public AudioClip perdiste;
    public GameObject soundtrack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySalto()
    {
        fuente.clip = salto;
        fuente.Play();
    }
    public void PlayMuerte()
    {
        fuente.clip = muerte;
        fuente.Play();
        soundtrack.SetActive(false);
    }
    public void PlayGanaste()
    {
        fuente.clip = ganaste;
        fuente.Play();
        soundtrack.SetActive(false);
    }
    public void PlayPerdiste()
    {
        fuente.clip = perdiste;
        fuente.Play();
        soundtrack.SetActive(false);
    }
}
