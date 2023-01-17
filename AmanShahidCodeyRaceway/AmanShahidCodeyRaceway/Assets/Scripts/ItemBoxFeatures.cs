using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxFeatures : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Rotate(transform.rotation.x + 1, transform.rotation.y + 1, transform.rotation.z + 1);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            gameObject.SetActive(false);
            Invoke("itemBoxRespawn", 2.0f);
        }
    }

    private void itemBoxRespawn() {
        gameObject.SetActive(true);
    }
}
