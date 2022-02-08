using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    protected override void Awake()
    {
        base.Awake();
        moveSpeed = 10;
        jumpForce = 10;
    }
}
