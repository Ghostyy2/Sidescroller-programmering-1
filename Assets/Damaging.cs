using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Damaging : MonoBehaviour
{
    public bool IsPlayer = false;
    public int DEATH = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsPlayer)
        {
            var enemyScript = collision.gameObject.GetComponent<MyEnemy>();
            if (enemyScript != null)
            {
                enemyScript.TakeDamage(DEATH);
            }
        }
        else
        {
          var PlayerScript = collision.gameObject.GetComponent<Controller>();
            if (PlayerScript != null)
            {
                PlayerScript.TakeDamage(DEATH);
            }
        }
    }
}