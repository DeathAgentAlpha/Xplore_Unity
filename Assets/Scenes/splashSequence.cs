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
            StartCoroutine(ToTutorialScene());
    }

    IEnumerator ToSplashTwo()
    {
        yield return new WaitForSeconds(2);
        sceneNumber = 1;
        SceneManager.LoadScene(1);
    }

    IEnumerator ToTutorialScene()
    {
        yield return new WaitForSeconds(2);
        sceneNumber = 2;
        SceneManager.LoadScene(2);
    }

}
