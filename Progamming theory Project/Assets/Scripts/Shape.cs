using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    LayerMask groundLayerMask;
    Rigidbody shapeRb;
    Collider shapeCollider;

    protected float moveSpeed = 5;
    protected float jumpForce = 7;

    // Start is called before the first frame update
    protected virtual void Awake()
    {
        shapeRb = GetComponent<Rigidbody>();
        shapeCollider = GetComponent<Collider>();
        groundLayerMask = LayerMask.GetMask("Ground");
    }

    void Update()
    {
        // Abstraction
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // Abstraction
        MoveShape();
    }

    void MoveShape()
    {
        Vector3 movementX = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        shapeRb.MovePosition(transform.position + movementX * Time.deltaTime * moveSpeed);
    }

    void Jump()
    {
        if(GroundCheck())
        shapeRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    bool GroundCheck()
    {
        float extraHeight = 0.3f;
        return Physics.Raycast(shapeCollider.bounds.center, Vector3.down, shapeCollider.bounds.extents.y + extraHeight, groundLayerMask);
    }
}
