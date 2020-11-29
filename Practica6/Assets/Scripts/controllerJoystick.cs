using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerJoystick : MonoBehaviour
{
    public Rigidbody player;
    public Transform playerCamera;
    public float speed = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float zMove = Input.GetAxisRaw("Vertical");

        player.velocity = playerCamera.forward * zMove * speed;
    }
}
