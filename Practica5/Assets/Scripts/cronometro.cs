using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cronometro : MonoBehaviour
{
    [SerializeField] private Text timer;
    private float time = 0.0f;
    private float limitTime = 80.0f;
    private winner textLoser;
    //public bool lose = false;
    private void Start()
    {
        textLoser = FindObjectOfType<winner>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timer.text = "Tiempo: " + time.ToString("f1");
        if (time > limitTime)
            textLoser.loseGame = true;
    }
}
