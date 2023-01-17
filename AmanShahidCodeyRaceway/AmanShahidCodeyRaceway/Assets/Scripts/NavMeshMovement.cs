using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    private GameObject target;
    private NavMeshAgent agent;
    void Start()
    {
        target = GameObject.FindWithTag("obstacle");
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "obstacle") {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    private void Despawn() {
        Destroy(gameObject);
    }
}
