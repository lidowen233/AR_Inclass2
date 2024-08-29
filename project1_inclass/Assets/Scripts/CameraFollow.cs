using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform player;  
    Vector3 _offset;        
    public float smoothSpeed = 0.125f; 

    void LateUpdate()
    {
        // camera position
        Vector3 desiredPosition = player.position + _offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        // keep camera always look at palyer
        transform.LookAt(player);
    }
}
