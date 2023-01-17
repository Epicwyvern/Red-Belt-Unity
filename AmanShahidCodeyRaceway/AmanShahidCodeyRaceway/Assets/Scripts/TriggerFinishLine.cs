using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && checkpointTracker.triggeredCheckpoints == checkpointTracker.numCheckpoints) {
            SceneManager.LoadScene(2);
        }
    }
}
