using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Damaging : MonoBehaviour
{
    public bool Isplayer = false;
    public int DEATH = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        var PlayerScript = collision.gameObject.GetComponent<Controller>();
        if (PlayerScript != null)
        {
            PlayerScript.TakeDamage(DEATH);
            ;

        }
    }

                
            
        }



