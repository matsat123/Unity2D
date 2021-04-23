using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public float jumpForce;
    public float liftingForce;

    public bool jumped;
    public bool doubleJumped;

    public LayerMask whatIsGround;

    private Rigidbody rb;
    private float timestamp;
    private BoxCollider boxCollider;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
    }

    
    void Update()
    {
        if (IsGrounded() && Time.time >= timestamp)
        {
            if (jumped || doubleJumped)
            {
                jumped = false;
                doubleJumped = false;
            }
            timestamp = Time.time + 1f;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!jumped)
            {
                rb.velocity = (new Vector3(0f, jumpForce));
                jumped = true;
            }
            else if (!doubleJumped)
            {
                rb.velocity = (new Vector3(0f, jumpForce));
                doubleJumped = true;
            }
        }

        if (Input.GetMouseButton(0))
        {
            rb.AddForce(new Vector3 (0f, liftingForce * Time.deltaTime, 0f));
        }
    }

    private bool IsGrounded()
    {
        bool hit = Physics.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, Vector3.down, new Quaternion { }, 0.2f, whatIsGround);
        return hit;
        
    }
}
