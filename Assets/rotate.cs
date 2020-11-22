using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(100f, 0f, 0f) * Time.deltaTime);
    }
}
