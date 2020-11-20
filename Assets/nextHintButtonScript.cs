using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextHintButtonScript : MonoBehaviour
{
    string btnName;
    public GameObject roomInfoText;
    public GameObject nextHintBtn;
    public GameObject nextHintText;
    public GameObject nextHintBtnText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit)){
                btnName = Hit.transform.name;
                if(btnName == "nextHintBtn")
                {
                    roomInfoText.SetActive(false);
                    nextHintBtn.SetActive(false);
                    nextHintBtnText.SetActive(false);
                    nextHintText.SetActive(true);
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                if (btnName == "nextHintBtn")
                {
                    roomInfoText.SetActive(false);
                    nextHintBtn.SetActive(false);
                    nextHintText.SetActive(true);
                }
            }
        }
    }
}
