using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire : MonoBehaviour
{
    [SerializeField] GameObject bullet = null;
    public AudioSource gun = null;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, gun.transform.position, gun.transform.rotation);
            gun.Play();
        }
    }
}
