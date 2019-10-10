using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000;
    public float YForce = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello, World!");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(forwardForce*Time.deltaTime, 0, 0 * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(0, YForce, 0); // If d is pressed 500 will be added to y axis.
        }

        if (Input.GetKey("f"))
        {
            rb.AddForce(0, -YForce, 0); 
        }
    }
}
