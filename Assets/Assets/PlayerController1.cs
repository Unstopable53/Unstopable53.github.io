using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1Controller : MonoBehaviour
{
    public Transform[] enemySpawn;
    public float enemySpawnCount;
    public float enemySpawnTime = 30;
    private float enemyscore = 0;
    public int Waves = 5;
    public Transform playerSpawn;
    public GameObject player;
    public GameObject enemies;
    public GameObject fastyEnemies;
    public GameObject HeavyEnemies;
    public TMP_Text tankText;
    public string scene;
    public string scene1;
    private bool tr = true;

    void Start()
    {
        Waves = Waves * 4;
        Instantiate(player, playerSpawn.position, Quaternion.identity);
        StartCoroutine(WaitEnemySpawn(enemySpawnTime));
    }

    IEnumerator WaitEnemySpawn(float t)
    {

        for (int i = 0; i < enemySpawnCount; i++)
        {
            enemyscore++;
            if (enemyscore % 7 == 0)
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
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && Waves == 0 && tr == true)
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Additive);
            tr = false;
        }
    }
}
