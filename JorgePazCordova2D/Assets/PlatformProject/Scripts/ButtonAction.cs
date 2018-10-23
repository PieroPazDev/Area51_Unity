using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{

    // Use this for initialization
    void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void QuitGame() {
#if UNITY_EDITOR    

        UnityEditor.EditorApplication.isPlaying = false;

#else
        Application.Quit();

#endif
        }

}