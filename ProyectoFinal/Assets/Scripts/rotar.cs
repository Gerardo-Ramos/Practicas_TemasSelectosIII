using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotar : MonoBehaviour
{
    public GameObject objetivo;
    public float velocidad = 120;
    private Vector3[] vectores= {Vector3.up, Vector3.down, Vector3.right, Vector3.left};
    private int numero;

    private void Start()
    {
        numero = Random.Range(0, 3);
    }
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(objetivo.transform.position, vectores[numero], velocidad * Time.deltaTime);
    }
}
