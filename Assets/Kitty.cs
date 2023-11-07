using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitty : MonoBehaviour
{
    public Rigidbody2D myRigidBody = null;

    public float MovenmentSpeedPerSecond = 10.0f;
    void Start()
    {
        
    }
    void FixedUpdate()
    {

        Vector3 characterVelocity = myRigidBody.velocity;
        characterVelocity.x = 0.0f;
        characterVelocity += MovenmentSpeedPerSecond * transform.right.normalized;
        myRigidBody.velocity = characterVelocity;

    }
}
