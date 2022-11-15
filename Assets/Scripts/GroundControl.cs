using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{
    float speed = 30;

    void Start()
    {

    }


    void Update()
    {
        float xMouse = Input.GetAxis("Mouse X");
        float yMouse = Input.GetAxis("Mouse Y");
        transform.eulerAngles += new Vector3(yMouse * Time.deltaTime * speed, 0f, -xMouse * Time.deltaTime * speed);
    }
}
