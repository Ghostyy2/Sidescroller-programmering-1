using JetBrains.Annotations;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.RuleTile.TilingRuleOutput;



public class Controller : MonoBehaviour
{
    
    public SpriteRenderer mySpriteRenderer = null;
    public List<Sprite> Charactersprites = new List<Sprite>();
       public int HP = 1;
    public int addhealth = 1;
    
    public Rigidbody2D myRigidBody = null;

    public CharacterState JumpingState = CharacterState.Airborne;
    public float movementSign = 1.0f;

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
        int hpCopy = HP - 1;

        if (hpCopy < 0)
        {
            hpCopy = 0;
        }
    
        if (hpCopy >= Charactersprites.Count)
        {
            hpCopy = Charactersprites.Count - 1;
        }
        
        mySpriteRenderer.sprite = Charactersprites[hpCopy];

        if (Input.GetKeyDown(KeyCode.W) && JumpingState == CharacterState.Grounded)
        {
            JumpingState = CharacterState.Jumping; 
            JumpHeightDelta = 0.0f; 
        }
        if (HP < 0)
        {
            Scenes mySceneLoader = gameObject.GetComponent<Scenes>();
            if (mySceneLoader != null)
            {
                mySceneLoader.LoadScene("Game Over");
            }
        }
       
       {
          
            
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

public void TakeDamage(int aHPValue)
    {
        HP += aHPValue;
    
    }


}
