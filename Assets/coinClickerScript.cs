using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class coinClickerScript : MonoBehaviour
{
    public GameObject vbObj;
    public GameObject roomInfoPlane;
    public GameObject roomInfoText;
    public GameObject nextHintText;
    public GameObject coin;
    public Text scoreText;

    void Start()
    {
        vbObj = GameObject.Find("coinClickerButton");
        vbObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(onButtonPressed);
        roomInfoPlane.SetActive(false);
        roomInfoText.SetActive(false);
        nextHintText.SetActive(false);
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if (coin.activeSelf)
        {
            coin.SetActive(false);
            roomInfoPlane.SetActive(true);
            roomInfoText.SetActive(true);
            string currScore = scoreText.text;
            int scoreInt = currScore[currScore.Length -1] - '0';
            ++scoreInt;
            currScore = currScore.Substring(0, currScore.Length - 1) + scoreInt.ToString();
            scoreText.text = currScore;
        }
        Debug.Log("Btn Pressed!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
