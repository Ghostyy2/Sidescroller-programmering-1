using UnityEditor.VersionControl;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;


public enum CharacterState
{
    Grounded = 0,
    Airborne = 1,
    Jumping = 2,
    Total

}
public class Moveyourbodyyeahyeahh : MonoBehaviour

{
    public Rigidbody2D myrigidbody = null;
    public CharacterState jumpingState = CharacterState.Airborne;

    public float Gravitypersecound = 160.0f;
    public float MovementSpeedpersecond = 10.0f;
    public float Groundlevel = 0.0f;
    
    public float JumpspeedFactor = 3.0f;
    public float JumpHeight = 150.0f;
    private float JumpHeightDelta = 0.0f;
  
  void Update()
    {
        bool isMoving = false;
       //gravity
        if(isMoving == false) 
    if(transform.position.y <= Groundlevel)
          
            { Vector3 characterPosition = transform.position;
                characterPosition.y = Groundlevel;
                transform.position = characterPosition;
                jumpingState = CharacterState.Grounded;
            }
          

        
        {
            Vector3 Gravityposition = transform.position;
            Gravityposition.y -= Gravitypersecound * Time.deltaTime;
            if (Gravityposition.y < Groundlevel) { Gravityposition.y = Groundlevel; }
            transform.position = Gravityposition;
        }




        //up
        if (Input.GetKey(KeyCode.W) && jumpingState == CharacterState.Grounded)
        {
            jumpingState = CharacterState.Jumping;
            JumpHeightDelta = 0.0f;
        }
        if (jumpingState == CharacterState.Jumping
            )

        { Vector3 characterPosition = transform.position;

            float totalJumpMOvementThisFrame = MovementSpeedpersecond * JumpspeedFactor * Time.deltaTime;
            
            characterPosition.y += totalJumpMOvementThisFrame;
            transform.position = characterPosition;
           
            JumpHeightDelta += totalJumpMOvementThisFrame;
            if(JumpHeightDelta >= JumpHeight)
            
            { jumpingState = CharacterState.Airborne;
                JumpHeightDelta = 0.0f;
            }
        }
        //left
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 characterposition = transform.position;
            characterposition.x -= MovementSpeedpersecond * Time.deltaTime;
            transform.position = characterposition;
        }
        
        //down
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 characterposition = transform.position;
            characterposition.y -= MovementSpeedpersecond * Time.deltaTime;
            transform.position = characterposition;
        }

        //right
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 characterposition = transform.position;
            characterposition.x += MovementSpeedpersecond * Time.deltaTime;
            transform.position = characterposition;
        }
    }
}


//Vector3 characterposition = transform.position;
//characterposition.y += MovementSpeedpersecond * Time.deltaTime;
//transform.position = characterposition;
//isMoving = true;