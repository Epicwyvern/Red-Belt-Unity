﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointCollision : MonoBehaviour
{
    public bool didCollide;
    public CheckpointCounter count;
    void Start()
    {
        didCollide = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && didCollide == false) {
            didCollide = true;
            count.triggeredCheckpoints++;
        }
        
    }
}