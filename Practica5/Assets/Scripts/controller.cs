using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private float speed = 4.5f;
    [SerializeField] private Transform cameraPlayer;
    private float limitAngle = 18;
    [SerializeField] private Rigidbody player;
    // Update is called once per frame
    void FixedUpdate()
    {
        float angle = cameraPlayer.rotation.eulerAngles.x;

        if (angle > limitAngle)
            player.velocity = cameraPlayer.forward * speed;
        else
            player.velocity  = Vector3.zero;



        //float h = Input.GetAxisRaw("Horizontal");
        //GetComponent<Rigidbody>().velocity = cameraPlayer.forward * h * speed;
    }
}
