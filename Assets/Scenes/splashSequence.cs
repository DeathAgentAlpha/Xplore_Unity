using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashSequence : MonoBehaviour
{
    public static int sceneNumber;

    void Start()
    {
        if(sceneNumber == 0)
            StartCoroutine(ToSplashTwo());
        if(sceneNumber == 1)
            StartCoroutine(ToMainScene());
    }

    IEnumerator ToSplashTwo()
    {
        yield return new WaitForSeconds(3);
        sceneNumber = 1;
        SceneManager.LoadScene(1);
    }

    IEnumerator ToMainScene()
    {
        yield return new WaitForSeconds(3);
        sceneNumber = 2;
        SceneManager.LoadScene(2);
    }

}
