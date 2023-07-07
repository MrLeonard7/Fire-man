using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   

public class MedalControl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Medalla");
        Destroy(gameObject);

        if (SceneManager.GetActiveScene().name == "Nivel_1")
        {
            SceneManager.LoadScene("Nivel_2");
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
