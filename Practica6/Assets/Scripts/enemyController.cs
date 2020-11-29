using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemyController : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;
    public Animator animatorEnemy;
    //private controller numEnemies;
    private controller kill;
    private GameObject player;
    private Collider bodyEnemy;
    public Image[] hearts;
    //public int enemyHit = 0;
    //public int numHearts = 3;
    //private bool isWatching = false;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //numEnemies = FindObjectOfType<spawnEnemy>();

        kill = FindObjectOfType<controller>();
        player = GameObject.Find("Player");
        bodyEnemy = GetComponent<Collider>();
        hearts[0] = GameObject.Find("h1").GetComponent<Image>();
        hearts[1] = GameObject.Find("h2").GetComponent<Image>();
        hearts[2] = GameObject.Find("h3").GetComponent<Image>();
    }
    void Update()
    {
        //if (Vector3.Distance(agent.destination, goal.position) < 10.0f)
        //{
        //    agent.destination = goal.position;
        //    animatorEnemy.SetBool("isWatching", true);
        //}   
        if(Vector3.Distance(agent.destination, player.transform.position) < 10.0f)
        {
            agent.destination = player.transform.position;
            animatorEnemy.SetBool("isWatching", true);
        }
        else
            animatorEnemy.SetBool("isWatching", false);

        if(kill.numHearts == 0)
        {
            agent.enabled = false;
            animatorEnemy.SetBool("isDead", true);
            Invoke("destroyEnemy", 3.0f);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet"){
            agent.enabled = false;
            //Destroy(gameObject);
            animatorEnemy.SetBool("isDead",true);
            Invoke("destroyEnemy",3.0f);
            Destroy(other.gameObject);
            kill.countEnemies -= 1;
            kill.enemiesKilled+= 1;
            bodyEnemy.enabled = false;
        }
        else if(other.tag == "Player")
        {
            //enemyHit++;
            kill.hits += 1;
            animatorEnemy.SetBool("isPunching",true);
            
            switch (kill.hits)
            {
                case 1:
                    if(kill.numHearts == 3)
                    {
                        hearts[2].enabled = false;
                        kill.numHearts--;
                    }
                    break;
                case 2:
                    if (kill.numHearts == 2)
                    {
                        hearts[1].enabled = false;
                        kill.numHearts--;
                    }
                    break;
                case 3:
                    if (kill.numHearts == 1)
                    {
                        hearts[0].enabled = false;
                        kill.numHearts--;
                    }
                    break;
                //default:
                //    enemyHit = 0;
                //    break;
            }
            Invoke("Running", 3.0f);
        }
    }

    void destroyEnemy()
    {
        Destroy(gameObject);
    }

    void Running()
    {
        animatorEnemy.SetBool("isPunching", false);
    }
}
