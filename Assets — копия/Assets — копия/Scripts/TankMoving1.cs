using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankMoving1 : MonoBehaviour
{
    public GameObject tank;
    float speed = 5;
    public float Hp = 2;
    public GameObject boom;
    public string scene;
    [SerializeField] GameObject spawn;
    private const float damage = 1;
    public GameObject tank2= null;
    float speed2 = 5;
    public float Hp2 = 2;
    public GameObject boom2;
    [SerializeField] GameObject spawn2=null;
    

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
        else if(Input.GetKey("d"))
        {
            tank.transform.rotation = Quaternion.Euler(0, 0, -90);
            tank.transform.Translate(0, speed * Time.deltaTime, 0);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tank2.transform.rotation = Quaternion.Euler(0, 0, 0);
            tank2.transform.Translate(0, speed2 * Time.deltaTime, 0);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            tank2.transform.rotation = Quaternion.Euler(0, 0, 180);
            tank2.transform.Translate(0, speed2 * Time.deltaTime, 0);

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            tank2.transform.rotation = Quaternion.Euler(0, 0, 90);
            tank2.transform.Translate(0, speed2 * Time.deltaTime, 0);

        }
        else  if(Input.GetKey(KeyCode.RightArrow))
        {
            tank2.transform.rotation = Quaternion.Euler(0, 0, -90);
            tank2.transform.Translate(0, speed2 * Time.deltaTime, 0);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyBullet"))
        {
            if (gameObject.tag == "Player")
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
                        Debug.Log(Hp);
                        Destroy(collision.gameObject);
                        Instantiate(boom, transform.position, transform.rotation);
                        Destroy(tank);
                    }
            }
            if (gameObject.tag == "Player2")
            {
                Hp2 = Hp2 - damage;
                if (Hp2 > 0)
                {
                    Debug.Log(Hp2);
                    Destroy(collision.gameObject);
                    tank2.transform.position = spawn2.transform.position;
                }   
                    if(Hp2 <= 0) { 
                        Debug.Log(Hp2);
                        Destroy(collision.gameObject);
                        Instantiate(boom2, transform.position, transform.rotation);
                        Destroy(tank2);
                    }
            }
        }
    }
    

    
}
