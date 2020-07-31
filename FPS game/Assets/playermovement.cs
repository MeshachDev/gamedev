using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 velociy=Vector3.zero;

   void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Move(Vector3 _velocity)
    {
        velociy = _velocity;

            }
    void FixedUpdate()
    {
       PerformMovement();

    }
    void PerformMovement()
    {
        if(velociy !=Vector3.zero)
        {
            rb.MovePosition(rb.position + velociy * Time.fixedDeltaTime);
        }
    }

}