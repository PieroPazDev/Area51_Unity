using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLevel : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "PlatformChar")
        {
            if (SceneManager.sceneCountInBuildSettings == SceneManager.GetActiveScene().buildIndex + 2)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
    }
}

