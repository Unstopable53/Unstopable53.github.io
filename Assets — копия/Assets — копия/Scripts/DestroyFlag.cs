using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyFlag : MonoBehaviour
{
    public GameObject flag;
    public string scene;
 private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("HeroBullet") || collision.CompareTag("EnemyBullet"))
    {
        Destroy(collision.gameObject);
        Instantiate(flag, transform.position, transform.rotation);
            SceneManager.LoadScene(scene, LoadSceneMode.Additive);
            Time.timeScale = 0;
            Destroy(gameObject);
    }
}
}
