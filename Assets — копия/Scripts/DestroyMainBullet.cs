using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyMainBullet : MonoBehaviour
{
    public GameObject boom;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyBullet"))
        {
            Destroy(collision.gameObject);
            Instantiate(boom, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (collision.CompareTag("MetalBlocks"))
        {
            Instantiate(boom, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
