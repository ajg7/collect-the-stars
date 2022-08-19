using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    int wholeNumber = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector3(0, 5, 0);
        }

        if (Input.GetKey("up")) 
        {
            rb.velocity = new Vector3(0, 0, 5);
        }

        if (Input.GetKey("down")) 
        {
            rb.velocity = new Vector3(0, 0, -5);
        }

        if (Input.GetKey("right")) 
        {
            rb.velocity = new Vector3(5, 0, 0);
        }

        if (Input.GetKey("left")) 
        {
            rb.velocity = new Vector3(-5, 0, 0);
        }
    }
}
