using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "PlatformChar")
        {
            if (SceneManager.sceneCountInBuildSettings == SceneManager.GetActiveScene().buildIndex +1 )
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}

