using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCounter : MonoBehaviour
{
    public int numCheckpoints;
    public int triggeredCheckpoints;
    void Start()
    {
        numCheckpoints = GameObject.FindGameObjectsWithTag("checkpoint").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
