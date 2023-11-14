using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class Powerup : MonoBehaviour
   
{
    private void OnCollisionEnter2D(Collision2D collision)
    
        
    {
        var playerScript = collision.gameObject.GetComponent<Controller>();
      if (playerScript != null)
        {
            
     
        }
    }
}
