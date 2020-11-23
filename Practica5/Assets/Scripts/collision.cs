using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    private winner textWinner;
    private void Start()
    {
        textWinner = FindObjectOfType<winner>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "calabaza")
            textWinner.winGame = true;
    }
}
