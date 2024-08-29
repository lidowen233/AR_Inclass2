using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    public float bounceForce = 5f; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
    }
    void OnCollisionEnter(Collision collision)
    {
      
        if (Mathf.Abs(rb.velocity.y) >= 0f)
        {
            rb.velocity = new Vector3(rb.velocity.x, bounceForce, rb.velocity.z);
        }
    }

}
