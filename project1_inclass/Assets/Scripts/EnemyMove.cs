using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float moveSpeed = 5f; 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(moveSpeed,0,0);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
   void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "wall")
        {
            moveSpeed = -moveSpeed;
            rb.velocity = new Vector3(moveSpeed,rb.velocity.y,rb.velocity.z);
        }
       
    }
}
