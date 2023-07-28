using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public string PauseMenuScene = null;
    public void HandleButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync(PauseMenuScene);
    }
}
