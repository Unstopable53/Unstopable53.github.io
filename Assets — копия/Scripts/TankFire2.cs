using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire2 : MonoBehaviour
{
    [SerializeField] GameObject bullet = null;
    public AudioSource gun = null;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, gun.transform.position, gun.transform.rotation);
            gun.Play();
        }
    }
}
