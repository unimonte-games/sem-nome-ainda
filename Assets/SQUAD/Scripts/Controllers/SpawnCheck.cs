﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCheck : MonoBehaviour
{
    public SpawnController SC;
    public Transform SpawnObj;

    private void Start()
    {
        Invoke("Atived", 1);
    }

    void Atived()
    {
        SC.List(SpawnObj);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            Destroy(gameObject);
            return;

        }         
    }

    

}
