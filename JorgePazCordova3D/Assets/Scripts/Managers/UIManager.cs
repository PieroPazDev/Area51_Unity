using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManager : MonoBehaviour {

    public Image fadePanel;

    public IEnumerator FadeProcess (Action fadeCall) {
        fadePanel.gameObject.SetActive(true);
        fadePanel.enabled = true;


        while (fadePanel.color.a != 1) {
            MoveImageAlpha(fadePanel, 1, 2f * Time.deltaTime);
            yield return null;
        }

        //EXTERNAL DESIRED METHOD SHOULD RETURN HERE
        fadeCall.Invoke();

        while (fadePanel.color.a != 0)
        {
            MoveImageAlpha(fadePanel, 0, 1f * Time.deltaTime);
            yield return null;
        }
        Debug.Log("Made it!");
    }

    void MoveImageAlpha (Image image, float targetAlpha, float speed) {
        Color color = image.color;
        color.a = Mathf.MoveTowards(color.a, targetAlpha, speed);
        image.color = color;
    }
}

// async operation 