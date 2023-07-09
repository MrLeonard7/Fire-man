using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;  
    }

    public void Menu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
