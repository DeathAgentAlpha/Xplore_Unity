using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class coinClickerScript : MonoBehaviour
{

    public GameObject vbObj;
    public GameObject roomInfoPlane;
    public GameObject roomInfoText;
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        vbObj = GameObject.Find("coinClickerButton");
        vbObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(onButtonPressed);
        roomInfoPlane.SetActive(false);
        roomInfoText.SetActive(false);
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if (coin.activeSelf)
        {
            coin.SetActive(false);
            roomInfoPlane.SetActive(true);
            roomInfoText.SetActive(true);

        }
        Debug.Log("Btn Pressed!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
