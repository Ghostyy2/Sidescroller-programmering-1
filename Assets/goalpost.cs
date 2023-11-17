using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalpost : MonoBehaviour
{
    public Scenes mySceneLoader = null;
    public string NextScene = "MainMenu";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var PlayerScript = collision.gameObject.GetComponent<Controller>();
        if (PlayerScript != null)
        {
            mySceneLoader.LoadScene(NextScene);
        }
    }
}