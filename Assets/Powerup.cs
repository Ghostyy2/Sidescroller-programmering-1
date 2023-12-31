using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class Powerup : MonoBehaviour

{
    public int AddHealth = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var PlayerScript = collision.gameObject.GetComponent<Controller>();
        if (PlayerScript != null)
        {
            PlayerScript.HP += AddHealth;
            AddHealth = 0;
            GameObject.Destroy(gameObject);
        }
    }
}