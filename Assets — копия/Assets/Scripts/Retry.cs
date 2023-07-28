using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    string currentSceneName;
    private void Start()
    {
       currentSceneName = SceneManager.GetActiveScene().name;  
    }
    

    public void HandleButtonClick()
    {
        SceneManager.LoadScene(currentSceneName);
    }
}
