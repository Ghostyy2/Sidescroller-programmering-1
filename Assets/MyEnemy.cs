using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    public void TakeDamage(int aHPValue)
    {
     

    }

    public Rigidbody2D myRigidBody = null;

    public float MovementSpeedPerSecond = 10.0f;
    public float MovementSign = 1.0f;


    void FixedUpdate()
    {
       
        Vector3 characterVelocity = myRigidBody.velocity;
        
        characterVelocity.x = 0;

        
        characterVelocity += MovementSign * MovementSpeedPerSecond * transform.right.normalized;

        
        myRigidBody.velocity = characterVelocity;


    }
}



