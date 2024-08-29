using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if(Input.GetKeyDown("space"))
        {
            if(isGrounded)
            {
                // only allow the jumping on the ground
                GetComponent<Rigidbody>().velocity = new Vector3(rb.velocity.x,5,rb.velocity.z);
                Debug.Log("jump");
            }
            
        }
        if(Input.GetKey("up"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(rb.velocity.x, rb.velocity.y,5);

        }
        if(Input.GetKey("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(rb.velocity.x, rb.velocity.y,-5);

        }
        if(Input.GetKey("left"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-5,rb.velocity.y, rb.velocity.z);

        }
        if(Input.GetKey("right"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(5,rb.velocity.y, rb.velocity.z);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        // if player on the platform
        if (collision.gameObject.tag == "platform")
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        // if player off the platform
        if (collision.gameObject.tag == "platform")
        {
            isGrounded = false;
        }
    }
}
