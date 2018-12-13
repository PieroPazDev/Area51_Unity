using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManager : MonoBehaviour
{

    public Image fadePanel;
    public float fadeSpeed = 2f;

    public IEnumerator FadeProcess(Action fadeCall) {

        fadePanel.gameObject.SetActive(true);
        fadePanel.enabled = true;
        yield return FadeTo(1);

        //EXTERNAL DESIRED METHOD SHOULD RETURN HERE
        fadeCall.Invoke();
        //__________________________________________
        yield return FadeTo(0);
    }

    //OVERLOAD
    public IEnumerator FadeProcess(Action<int> fadeCall, int invokeParam) {
        fadePanel.gameObject.SetActive(true);
        fadePanel.enabled = true;
        yield return FadeTo(1);
        //EXTERNAL DESIRED METHOD SHOULD RETURN HERE
        fadeCall.Invoke(invokeParam);
        //__________________________________________
        yield return FadeTo(0);
    }

    IEnumerator FadeTo(int targerValue){
        while (fadePanel.color.a != targerValue){
            MoveImageAlpha(fadePanel, targerValue, fadeSpeed * Time.deltaTime);
            yield return null;
        }   
    }

    void MoveImageAlpha(Image image, float targetAlpha, float speed)
        {
            Color color = image.color;
            color.a = Mathf.MoveTowards(color.a, targetAlpha, speed);
            image.color = color;
            
        }
    }


// async operation 

// delegate almacena direcciones de memoria de metodos o funciones : lista de direcciones de memoria
// action brapper para delegate
// delegate para procesos ascincronos y procesos ordenados

// que hace una coroutine :manejar procesos asincronos dentro de un mismo thread