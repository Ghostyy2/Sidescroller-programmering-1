using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Scenes : MonoBehaviour
{
    public void LoadScene(string aObject)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(aObject);
     
       
       
    }

}
