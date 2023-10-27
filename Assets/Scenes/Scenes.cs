using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenes : MonoBehaviour
{
    public void LoadScene(string aObject)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(aObject);

    }

}
