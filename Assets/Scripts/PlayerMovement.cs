using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
 
    // Update is called once per frame
    void FixedUpdate() {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // moves the cube in forward direction

        if (Input.GetKey("d"))   
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);  // moves the cube towards right
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);  // moves the cube towards left
        }


        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}
 