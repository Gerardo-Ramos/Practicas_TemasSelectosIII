using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionBullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
            Invoke("destroyBullet",0.5f);
    }

    void destroyBullet()
    {
        Destroy(gameObject);
    }

}
