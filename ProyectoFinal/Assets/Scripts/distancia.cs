using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distancia : MonoBehaviour
{
    public Transform atomo1;
    public Transform atomo2;
    public Transform atomo3;
    public Animator cerca;
    public GameObject nuevoElemento;
    public GameObject texto;
    public GameObject sonido;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        if (atomo1.gameObject.activeInHierarchy & !atomo2.gameObject.activeInHierarchy & !atomo3.gameObject.activeInHierarchy)
        {
            texto.SetActive(true);
            sonido.SetActive(true);
        }
    }
}
