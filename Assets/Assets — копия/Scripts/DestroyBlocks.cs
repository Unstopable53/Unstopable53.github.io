using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyBlocks : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("HeroBullet") || collision.CompareTag("EnemyBullet"))
        {
            Destroy(collision.gameObject);;
            Destroy(gameObject);
        }
    }
}
