using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public Animator botones;
    private bool click = false;
    public void Salir()
    {
        Application.Quit();
    }

    public void Recargar()
    {
        SceneManager.LoadScene("principal");
    }

    public void URL()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1PndvQ1JScrDAF-KaOd414SoEZ2ZxW8xz?usp=sharing");
    }

    public void conf()
    {
        click = !click;
        if (click)
            botones.SetBool("menu", true);
        else
            botones.SetBool("menu", false);
    }
}
