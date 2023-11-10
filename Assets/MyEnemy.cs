using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    Kitty MyenemyScript = null;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 enemyscale = MyenemyScript.transform.localScale;
        enemyscale.x = -enemyscale.x;
        MyenemyScript.transform.localScale = enemyscale;
        MyenemyScript.MovenmentSpeedPerSecond *= -1;
    }




}