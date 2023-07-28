using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThemselves : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1);
    }
}
