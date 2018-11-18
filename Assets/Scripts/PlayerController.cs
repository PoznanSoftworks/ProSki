using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    private ConstantForce cf;
    private Rigidbody rb;

    void Start()
    {
        cf = GetComponent<ConstantForce>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            print("left");
            rb.AddRelativeForce(Vector3.left * 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            print("right");
            rb.AddRelativeForce(Vector3.right * 1);
        }


    }
}
