﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BuoyantForce : MonoBehaviour
{
    public float waterLevel;
    public float floatHeight=1f;
    public Vector3 buoyancyCentreOffset=new Vector3(0,1f,0);
    public float bounceDamp=0.5f;

    Rigidbody rig;
   
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        var actionPoint = transform.position + transform.TransformDirection(buoyancyCentreOffset);
        var forceFactor = 1f - ((actionPoint.y - waterLevel) / floatHeight);

        if (forceFactor > 0f)
        {
            var uplift = -Physics.gravity * (forceFactor - rig.velocity.y * bounceDamp);
            rig.AddForceAtPosition(uplift, actionPoint);
        }
    }
}
