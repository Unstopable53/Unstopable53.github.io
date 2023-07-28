using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoving1 : MonoBehaviour
{
    public GameObject tank;
    float speed = 5;
    public float Hp = 2;
    public GameObject boom;
    [SerializeField] GameObject spawn;
    private const float damage = 1;
    public string scene;
    private void Update()
    {

        if (Input.GetKey("w"))
        {
            tank.transform.rotation = Quaternion.Euler(0, 0, 0);
            tank.transform.Translate(0, speed * Time.deltaTime, 0);

        }
        else if (Input.GetKey("s"))
        {
            tank.transform.rotation = Quaternion.Euler(0, 0, 180);
            tank.transform.Translate(0, speed * Time.deltaTime, 0);

        }
        else if (Input.GetKey("a"))
        {
            tank.transform.rotation = Quaternion.Euler(0, 0, 90);
            tank.transform.Translate(0, speed * Time.deltaTime, 0);

        }
        else if (Input.GetKey("d"))
        {
            tank.transform.rotation = Quaternion.Euler(0, 0, -90);
            tank.transform.Translate(0, speed * Time.deltaTime, 0);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyBullet"))
        {
                Hp = Hp - damage;
                if (Hp > 0)
                {
                    Debug.Log(Hp);
                    Destroy(collision.gameObject);
                    tank.transform.position = spawn.transform.position;
                }
                if (Hp <= 0)
                {
                SceneManager.LoadScene(scene, LoadSceneMode.Additive);
                    Debug.Log(Hp);
                    Destroy(collision.gameObject);
                    Instantiate(boom, transform.position, transform.rotation);
                    Destroy(tank);
                }
            
        }
    }



}


