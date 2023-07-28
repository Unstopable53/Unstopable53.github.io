using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public GameObject boom;
    private void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("HeroBullet"))
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
