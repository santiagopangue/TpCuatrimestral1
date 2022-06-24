using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public int vidas;
    public Text txt_vidas;
    public Text txt_perdiste;
    public GameObject btn_reiniciar;
    public GameObject camara;
    public AudioManager miAM;

    void Start()
    {
        vidas = 10;
    }

    void Update()
    {
        txt_vidas.text = "Vidas: " + vidas;

        if (transform.position.y < -3f)
        {
            vidas--;
            transform.position = new Vector3(0, 1, 0);
            miAM.PlayMuerte();
        }
        if(vidas <= 0)
        {
            txt_perdiste.text = "Perdiste!!";
            Destroy(gameObject);
            btn_reiniciar.SetActive(true);
            camara.SetActive(true);
            miAM.PlayPerdiste();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ventilador")
        {
            vidas--;
            miAM.PlayMuerte();
        }
        if (col.gameObject.name == "Tronco(Clone)")
        {
            vidas--;
            miAM.PlayMuerte();
        }
        if (col.gameObject.name == "PisoChicoTrampa1")
        {
            vidas--;
        }
        if (col.gameObject.name == "PisoChicoTrampa2")
        {
            vidas--;
        }
    }
}
