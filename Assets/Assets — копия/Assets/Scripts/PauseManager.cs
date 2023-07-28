using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
        public string PauseScene = null;
        private void Awake()
        {
            Time.timeScale = 1;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (SceneManager.GetSceneByName(PauseScene).isLoaded == false)
                {
                    Time.timeScale = 0;
                    SceneManager.LoadScene(PauseScene, LoadSceneMode.Additive);
                }
                else
                {
                    Time.timeScale = 1;
                    SceneManager.UnloadSceneAsync(PauseScene);
                }
            }
        }
    }
