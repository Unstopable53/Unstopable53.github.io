using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string MainManuScene = null;
    public void HandleButtonClick()
    {
        SceneManager.LoadScene(MainManuScene);
    }
}
