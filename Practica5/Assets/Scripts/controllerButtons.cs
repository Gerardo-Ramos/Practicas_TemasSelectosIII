using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controllerButtons : MonoBehaviour
{
    [SerializeField] private GameObject controls;
    public void Quit()
    {
        Application.Quit();
    }

    public void Comenzar()
    {
        controls.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Practica5");
    }
}
