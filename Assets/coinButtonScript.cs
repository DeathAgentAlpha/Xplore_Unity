using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class coinButtonScript : MonoBehaviour{

    public GameObject vbObj;
    public GameObject roomInfoPlane;
    public GameObject roomInfoText;
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        vbObj = GameObject.Find("coinButton");
        vbObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(onButtonPressed);
        roomInfoPlane.SetActive(false);
        roomInfoText.SetActive(false);
        //Renderer roomInfoPlaneRend = roomInfoPlane.GetComponent<Renderer>();
        //Renderer roomInfoTextRend = roomInfoText.GetComponent<Renderer>();
        //roomInfoPlaneRend.enabled = false;
        //roomInfoTextRend.enabled = false;
        //vbObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(onButtonReleased);
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        //Renderer coinRend = coin.GetComponent<Renderer>();
        //Renderer roomInfoPlaneRend = roomInfoPlane.GetComponent<Renderer>();
        //Renderer roomInfoTextRend = roomInfoText.GetComponent<Renderer>();
        if (coin.activeSelf)
        {
            //coinRend.enabled = false;
            //roomInfoPlaneRend.enabled = true;
            //roomInfoTextRend.enabled = true;
            coin.SetActive(false);
            roomInfoPlane.SetActive(true);
            roomInfoText.SetActive(true);

        }
        Debug.Log("Btn Pressed!");
    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Btn Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
