using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{

    public Text txt_timer;
    public Text txt_ganaste;
    public Text txt_perdiste;
    public GameObject btn_reiniciar;
    float tiempo = 120;
    public GameObject camara;
    public AudioManager miAM;

    void Start()
    {

    }

    void Update()
    {
        tiempo -= Time.deltaTime;
        txt_timer.text = tiempo.ToString("f0");

        if (tiempo <= 0)
        {
            txt_perdiste.text = "Perdiste!!";
            Destroy(gameObject);
            btn_reiniciar.SetActive(true);
            camara.SetActive(true);
            Destroy(gameObject);
            miAM.PlayPerdiste();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "PisoChicoTrampa1")
        {
            transform.position = new Vector3(0f, 1f, 0f);
            miAM.PlayMuerte();
        }
   
        if (col.gameObject.name == "PisoChicoTrampa2")
        {
            transform.position = new Vector3(0f, 1f, 0f);
            miAM.PlayMuerte();
        }
        if(col.gameObject.name == "PisoFinal")
        {
            txt_ganaste.text = "Ganaste!!";
            btn_reiniciar.SetActive(true);
            Destroy(gameObject);
            camara.SetActive(true);
            miAM.PlayGanaste();
        }
    }
}
