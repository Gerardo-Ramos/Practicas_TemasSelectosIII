using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearNitro : MonoBehaviour
{
    public Transform atomo1;
    public Transform atomo2;
    public Animator cerca;
    public GameObject nuevoElemento;
    public GameObject texto,textoN;
    public GameObject sonido,sonidoN;
    private bool click = false;

    // Update is called once per frame
    void Update()
    {
        if (atomo1.gameObject.activeInHierarchy & atomo2.gameObject.activeInHierarchy)
        {
            if (Vector3.Distance(atomo1.position, atomo2.position) < 7.0f)
            {
                if (atomo2.position.x > 0)
                    cerca.SetBool("cercaN", true);
            }
        }
    }

    public void mostrarInfo()
    {
        click = !click;
        if (click)
        {
            if (atomo1.gameObject.activeInHierarchy & !atomo2.gameObject.activeInHierarchy)
            {
                texto.SetActive(true);
                sonido.SetActive(true);
            }

            else if (!atomo1.gameObject.activeInHierarchy & atomo2.gameObject.activeInHierarchy)
            {
                textoN.SetActive(true);
                sonidoN.SetActive(true);
            }
        }
        else
        {
            texto.SetActive(false);
            sonido.SetActive(false);
            textoN.SetActive(false);
            sonidoN.SetActive(false);
            click = false;
        }
            
    }
}
