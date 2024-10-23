using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Collections.AllocatorManager;

public class MainMenu : MonoBehaviour
{
    public string sceneName;

    public void SceneChange()
    {
        //Load scene
        Debug.Log("start button clicked");
        SceneManager.LoadScene("Black Vine");
    }

}
