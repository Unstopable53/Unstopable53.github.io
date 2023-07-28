using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Controller : MonoBehaviour
{
    public float countTank = 1;
    public Transform[] enemySpawn;
    public float enemySpawnCount;
    public float enemySpawnTime = 30;
    private float enemyscore = 0;
    public int Waves = 5;
    public Transform playerSpawn;
    public Transform playerSpawn2;
    public GameObject player;
    public GameObject player2;
    public GameObject enemies;
    public GameObject fastyEnemies;
    public GameObject HeavyEnemies;
    public TMP_Text tankText;
    public string scene;
    public string scene1;
    private bool tr = true;
    private bool tre = true;


    void Start()
    {
        countTank = countTank * 4;
        Waves = Waves * 4;
        Instantiate(player, playerSpawn.position, Quaternion.identity);
        Instantiate(player2, playerSpawn2.position, Quaternion.identity);
        StartCoroutine(WaitEnemySpawn(enemySpawnTime));
    }

    IEnumerator WaitEnemySpawn(float t)
    {
        
            for (int i = 0; i < enemySpawnCount; i++)
            {
                enemyscore++;
            if(enemyscore % 7 == 0)
            {
                Waves--;
                Instantiate(HeavyEnemies, enemySpawn[i].position, Quaternion.identity);
            }
                if (enemyscore % 3 == 0)
                {
                Waves--;
                Instantiate(fastyEnemies, enemySpawn[i].position, Quaternion.identity);

                }
                else
                {
                Waves--;
                    Instantiate(enemies, enemySpawn[i].position, Quaternion.identity);
                }
                
            }
        yield return new WaitForSeconds(t);
        if (Waves > 0) StartCoroutine(WaitEnemySpawn(enemySpawnTime));
    }
    void OnGUI()
    {
        
        tankText.text = "Tanks:\n" + Waves;
    }

    void Update()
    {
        if (tre == true && GameObject.FindGameObjectsWithTag("Player").Length == 0 && GameObject.FindGameObjectsWithTag("Player2").Length == 0)
        {
            tre = false;
            SceneManager.LoadScene(scene1, LoadSceneMode.Additive);
            
        }
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && Waves == 0 && tr == true)
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Additive);
            tr = false;
        }
    }
}
