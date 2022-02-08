using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{

    protected override void Awake()
    {
        base.Awake();
        moveSpeed = 5;
        jumpForce = 6;
    }

}
