using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour
{
    public float force = 10f;
    public Transform target;
    public Transform CameraTransform;
    public float SpeedTreeWindAsset = 5f;
    public Rigidbody rb;


  
    void FixedUpdate()
    {
        rb.AddForce (Vector3 . forward * force);
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * SpeedTreeWindAsset * Time.deltaTime);
    }
    void LateUpdate()
    {
        CameraTransform.LookAt(target);
    }
 

}
