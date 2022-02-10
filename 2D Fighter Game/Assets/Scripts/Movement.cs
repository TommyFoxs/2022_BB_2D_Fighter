using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7.5f;

    public Rigidbody2D myRigidBody2D;
    public CircleCollider2D feet;

    private float horizontalMovement = 0;
    public int facing = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        
    }

    void FixedUpdate()
    {
         myRigidBody2D.velocity = new Vector2(horizontalMovement  * speed, myRigidBody2D.velocity.y);
    }
}
