using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    private float speed = 6.5f;
    [SerializeField] private Transform cameraPlayer;
    private float limitAngle = 18;
    [SerializeField] private Rigidbody player;
    public Text score;
    public int enemiesKilled = 0;
    public GameObject textWin, textLose;
    public int hits = 0;
    public int numHearts = 3;
    public int countEnemies;

    private void Start()
    {

    }
    // Update is called once per frame
    private void Update()
    {
        score.text = "Enemigos: " + enemiesKilled.ToString();
        if(numHearts == 0)
        {
            textLose.SetActive(true);
            GameObject.Find("ControlHead").SetActive(false);
            GameObject.Find("Gun").SetActive(false);
            GameObject.Find("SpawnEnemy").SetActive(false);
        }
        if (enemiesKilled >= 10)
        {
            textWin.SetActive(true);
            GameObject.Find("ControlHead").SetActive(false);
            GameObject.Find("Gun").SetActive(false);
            GameObject.Find("SpawnEnemy").SetActive(false);
        }
            
    }
    void FixedUpdate()
    {
        //GameObject.Find("Main Camera").transform.position = new Vector3(0, 1, 0);
        float angle = cameraPlayer.rotation.eulerAngles.x;

        if (angle > limitAngle)
            player.velocity = cameraPlayer.forward * speed;
        else
            player.velocity  = Vector3.zero;


        
        //float h = Input.GetAxisRaw("Horizontal");
        //GetComponent<Rigidbody>().velocity = cameraPlayer.forward * h * speed;
    }
}
