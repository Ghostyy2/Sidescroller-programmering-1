using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaging : MonoBehaviour
{
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