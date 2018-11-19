using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {


    private ConstantForce cf;
    private Rigidbody rb;
    private float timer = 0.0f;
    private Boolean reset = false;


    void Start()
    {
        cf = GetComponent<ConstantForce>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            timer += Time.deltaTime;
            rb.AddRelativeForce(Vector3.right * 1);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (timer < 0.5)
            {
                rb.AddRelativeForce(Vector3.right * 75);
            }
            else
            {
                timer = 0;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            timer += Time.deltaTime;
            rb.AddRelativeForce(Vector3.left * 1);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (timer < 0.5)
            {
                rb.AddRelativeForce(Vector3.left * 75);
            }
            else
            {
                timer = 0;
            }
        }
    }
}
