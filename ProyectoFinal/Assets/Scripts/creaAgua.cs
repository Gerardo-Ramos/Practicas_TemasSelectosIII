using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creaAgua : MonoBehaviour
{
    public Transform atomo1, atomo2;
    public Transform atomo3;
    public Animator cerca;
    public GameObject nuevoElemento;
    public GameObject texto, textoH, textoH2;
    public GameObject sonido, sonidoH, sonidoH2;
    private bool click = false;

    // Update is called once per frame
    void Update()
    {
        if (atomo1.gameObject.activeInHierarchy & atomo2.gameObject.activeInHierarchy & atomo3.gameObject.activeInHierarchy)
        {
            if (Vector3.Distance(atomo1.position, atomo2.position) < 7.0f & Vector3.Distance(atomo1.position, atomo3.position) < 7.0f)
            {
                if (atomo2.position.x > 0 & atomo3.position.x < 0)
                    cerca.SetBool("cerca", true);
            }
        }
    }
    public void mostrarInfo()
    {
        click = !click;
        if (click)
        {
            if (atomo1.gameObject.activeInHierarchy & !atomo2.gameObject.activeInHierarchy & !atomo3.gameObject.activeInHierarchy)
            {
                texto.SetActive(true);
                sonido.SetActive(true);
            }
            else if (!atomo1.gameObject.activeInHierarchy & atomo2.gameObject.activeInHierarchy & !atomo3.gameObject.activeInHierarchy)
            {
                textoH.SetActive(true);
                sonidoH.SetActive(true);
            }
            else if (!atomo1.gameObject.activeInHierarchy & !atomo2.gameObject.activeInHierarchy & atomo3.gameObject.activeInHierarchy)
            {
                textoH2.SetActive(true);
                sonidoH2.SetActive(true);
            }
        }
        else
        {
            texto.SetActive(false);
            sonido.SetActive(false);
            textoH.SetActive(false);
            sonidoH.SetActive(false);
            textoH2.SetActive(false);
            sonidoH2.SetActive(false);
            click = false;
        }

    }
}

