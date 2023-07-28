using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletMoving : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
