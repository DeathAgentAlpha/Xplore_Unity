using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMainSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToMaineScene()
    {
        SceneManager.LoadScene(2);
    }
}
