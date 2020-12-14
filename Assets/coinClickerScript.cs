using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class coinClickerScript : MonoBehaviour
{
    public GameObject imageTarget;
    public GameObject vbObj;
    public GameObject nextCoin;
    public progessBarScript barIncreaseScr;

    GameObject coin;
    GameObject roomInfoPlane;
    GameObject nextHintPlane;
    Text scoreText;

    void Start()
    {
        coin = imageTarget.transform.GetChild(0).gameObject;
        roomInfoPlane = imageTarget.transform.GetChild(2).gameObject;
        nextHintPlane = imageTarget.transform.GetChild(3).gameObject;
        scoreText = GameObject.Find("coinScoreText").GetComponent<Text>();

        vbObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(onButtonPressed);
        roomInfoPlane.SetActive(false);
        nextHintPlane.SetActive(false);
        nextCoin.SetActive(false);
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if (coin.activeSelf)
        {
            coin.SetActive(false);
            roomInfoPlane.SetActive(true);
            nextCoin.SetActive(true);
            string currScore = scoreText.text;
            int scoreInt = currScore[currScore.Length -1] - '0';
            ++scoreInt;
            currScore = currScore.Substring(0, currScore.Length - 1) + scoreInt.ToString();
            scoreText.text = currScore;
            barIncreaseScr.IncrementProgress(0.25f);

        }
        //Debug.Log("Btn Pressed!");
    }

    public void onFButtonPressed()
    {
        if (coin.activeSelf)
        {
            coin.SetActive(false);
            roomInfoPlane.SetActive(true);
            nextCoin.SetActive(true);
            string currScore = scoreText.text;
            int scoreInt = currScore[currScore.Length - 1] - '0';
            ++scoreInt;
            currScore = currScore.Substring(0, currScore.Length - 1) + scoreInt.ToString();
            scoreText.text = currScore;
            barIncreaseScr.IncrementProgress(0.25f);

        }
        //Debug.Log("Btn Pressed!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
