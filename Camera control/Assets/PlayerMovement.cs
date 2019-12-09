using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    

    private void Start()
    {
        rb = GetComponent < Rigidbody >();
    }

    void FixedUpdate()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(mH * speed * Time.deltaTime, rb.velocity.y, mV * speed * Time.deltaTime);
    }
}
