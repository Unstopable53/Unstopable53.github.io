using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTank : MonoBehaviour
{
    public int HP = 1;
    public float speed = 100f;
    public Transform tank;
    public float minMoveTime = 0.5f;
    public float maxMoveTime = 5.5f;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private Vector3 rotation;
    private int move;
    public GameObject boom;
    void Start()
    {
        move = 0;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(WaitMove(Random.Range(minMoveTime, maxMoveTime)));
    }
    IEnumerator WaitMove(float t)
    {
        move = Random.Range(0, 4);
        yield return new WaitForSeconds(t);
        StartCoroutine(WaitMove(Random.Range(minMoveTime, maxMoveTime)));
    }

    void FixedUpdate()
    {
        rb.velocity = moveDirection * speed;
       
    }

    void Update()
    {
        switch (move)
        {
            case 1:moveDirection = new Vector2(0, 1);rotation = new Vector3(0, 0, 180);break;

            case 2:moveDirection = new Vector2(0, -1);rotation = new Vector3(0, 0, 0);break;

            case 3: moveDirection = new Vector2(-1, 0);rotation = new Vector3(0, 0, -90);break;

            case 4:moveDirection = new Vector2(1, 0);rotation = new Vector3(0, 0, 90);break;

            default: moveDirection = new Vector2(0, 0); break;
        }

        tank.localRotation = Quaternion.Euler(rotation);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("HeroBullet"))
        {
            HP--;
            if (HP == 0)
            {
                Destroy(collision.gameObject);
                Instantiate(boom, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
