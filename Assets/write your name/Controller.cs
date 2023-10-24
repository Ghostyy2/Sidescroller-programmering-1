using UnityEditor.VersionControl;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;



public class Controller : MonoBehaviour
{
    
    public Rigidbody2D myRigidBody = null;

    public CharacterState JumpingState = CharacterState.Airborne;
   

    //Gravity
    public float GravityPerSecond = 160.0f; //Falling Speed
    public float GroundLevel = 0.0f; //Ground Value

    //Jump 
    public float JumpSpeedFactor = 3.0f;
    public float JumpMaxHeight = 150.0f;
    
    public float JumpHeightDelta = 0.0f;

    //Movement
    public float MovementSpeedPerSecond = 10.0f;





    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && JumpingState == CharacterState.Grounded)
        {
            JumpingState = CharacterState.Jumping; 
            JumpHeightDelta = 0.0f; 
        }
    }

    void FixedUpdate()
    {
        Vector3 characterVelocity = myRigidBody.velocity;
        characterVelocity.x = 0.0f;

        if (JumpingState == CharacterState.Jumping)
        {
            float jumpMovement = MovementSpeedPerSecond * JumpSpeedFactor;
            characterVelocity.y = jumpMovement;

            JumpHeightDelta += jumpMovement * Time.deltaTime;

            if (JumpHeightDelta >= JumpMaxHeight)
            {
                JumpingState = CharacterState.Airborne;

            }
        }

        //Left
        if (Input.GetKey(KeyCode.A))
        {
            characterVelocity.x -= MovementSpeedPerSecond;
        }
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            characterVelocity.x += MovementSpeedPerSecond;
        }
        myRigidBody.velocity = characterVelocity;

    }
}
