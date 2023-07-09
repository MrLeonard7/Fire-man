using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenuOpciones : MonoBehaviour
{
    public void Regresar()
    {
        
        if (SceneManager.GetActiveScene().name == "Pantalla_Informacion")
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    public void Ayuda()
    {
        SceneManager.LoadScene(3);
    }

    public void Informacion()
    {
        SceneManager.LoadScene(4);
    }
}
