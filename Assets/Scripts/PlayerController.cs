using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {


    private ConstantForce cf;
    private Rigidbody rb;

    private DateTime checkTimeStart;
    private DateTime checkTimeEnd;
    private double tapController;

    void Start()
    {
        cf = GetComponent<ConstantForce>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    { 
        
        if (Input.GetKey(KeyCode.LeftArrow))
        { 
            checkTimeStart = DateTime.Now;
            rb.AddRelativeForce(Vector3.right * 1);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            tapController = DateTime.Now.Subtract(checkTimeStart).TotalSeconds;
            //print(tapController);

            if (tapController < 0.005)
            {
                rb.AddRelativeForce(Vector3.right * 50);
                checkTimeStart = DateTime.Now;
                tapController = 0;
                print(tapController);
            } 
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            checkTimeStart = DateTime.Now;
            rb.AddRelativeForce(Vector3.left * 1);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            tapController = DateTime.Now.Subtract(checkTimeStart).TotalSeconds;
            //print(tapController);
            if (tapController < 0.005)
            {
                print(tapController);
                rb.AddRelativeForce(Vector3.left * 50);
                checkTimeStart = DateTime.Now;
                tapController = 0;
            }
        }

    }
}
