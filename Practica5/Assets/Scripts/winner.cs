using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winner : MonoBehaviour
{
    [SerializeField] private GameObject winnerText, loserText;
    public bool loseGame = false;
    public bool winGame = false;
    [SerializeField] private GameObject controls;
    [SerializeField] private Transform player;

    // Update is called once per frame
    void Update()
    {
        if (loseGame)
        {
            loseGame = false;
            loserText.transform.position = new Vector3(player.position.x, player.position.y, player.position.z);
            loserText.transform.rotation = player.rotation;
            loserText.SetActive(true);
            controls.SetActive(false);
        }
            
        if (winGame)
        {
            winGame = false;
            winnerText.transform.position = new Vector3(player.position.x+5.0f, player.position.y, player.position.z);
            winnerText.transform.rotation = new Quaternion(player.rotation.x, player.rotation.y, player.rotation.z,1);
            winnerText.SetActive(true);
            controls.SetActive(false);
        }
    }
}
