using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource gun;
    bool ready = true;
    public float minTime = 0.5f;
    public float maxTime = 3.5f;
    void Start()
    {
        StartCoroutine(Fire(Random.Range(minTime, maxTime)));
    }

  
    void Update() { 
        
        if(ready)
        {
Instantiate(bullet, gun.transform.position, gun.transform.rotation);
            gun.Play();
            ready = false;
        }
        else
        {
            Fire(Random.Range(minTime, maxTime));
        }
        
    }
    IEnumerator Fire(float t)
    {
        while(true) {  yield return new WaitForSeconds(t);
     ready = true;

        }
    }

}
