using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveLeftAndRight : MonoBehaviour
{
    private Rigidbody2D rb;

    //float horizontal;
    //float vertical;

    public float runSpeed = 10.0f;
    private Vector2 moveVelocity;


    // public Transform launchOffset;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //bez "Raw" za smooth kretanje!
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * runSpeed;

        //horizontal = Input.GetAxisRaw("Horizontal");
        //vertical = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

}

