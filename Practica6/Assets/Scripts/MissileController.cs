using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    [SerializeField] private Rigidbody proyectil;
    private float velocidad = 30.0f;
    private Rigidbody instanciaProyectil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            instanciaProyectil = Instantiate(proyectil, transform.position, transform.rotation);
            instanciaProyectil.velocity = transform.TransformDirection(new Vector3(0, 0, velocidad));
            Physics.IgnoreCollision(instanciaProyectil.GetComponent<Collider>(), transform.root.GetComponent<Collider>());
        }
    }
}
