using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
    public string Scene = null;
    public void HandleButtonClick()
    {
        SceneManager.LoadScene(Scene);
    }
}
