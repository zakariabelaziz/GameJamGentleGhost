using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{

    float speed = 4.0f;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                     Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed, 0.0f);
        }

        else if (Input.GetAxis("Mouse X") < 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                        Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed, 0.0f);
        }

    }

}