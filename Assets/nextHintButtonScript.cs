using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;


public class nextHintButtonScript : MonoBehaviour
{
    public GameObject ImageTarget;
    GameObject roomInfoPlane;
    GameObject nextHintPlane;
    GameObject nextHintBtn;
    GameObject nextHintBtnText;

    void Start()
    {
        roomInfoPlane = ImageTarget.transform.GetChild(2).gameObject;
        nextHintPlane = ImageTarget.transform.GetChild(3).gameObject;
        nextHintBtn = roomInfoPlane.transform.GetChild(0).gameObject;
        nextHintBtnText = nextHintBtn.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit)){
                string btnName = Hit.transform.name;
                if(btnName == nextHintBtn.transform.name)
                {
                    roomInfoPlane.SetActive(false);
                    nextHintBtn.SetActive(false);
                    nextHintBtnText.SetActive(false);
                    nextHintPlane.SetActive(true);
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                string btnName = Hit.transform.name;
                if (btnName == nextHintBtn.transform.name)
                {
                    roomInfoPlane.SetActive(false);
                    nextHintBtn.SetActive(false);
                    nextHintBtnText.SetActive(false);
                    nextHintPlane.SetActive(true);
                }
            }
        }
    }
}
