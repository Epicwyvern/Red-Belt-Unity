using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
        Invoke("Despawn", 5.0f);
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
