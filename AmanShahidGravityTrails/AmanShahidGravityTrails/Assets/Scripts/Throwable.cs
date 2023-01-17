using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;

    public int throwableCounter;

    public Text collectibleCounter;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Collectable") {
            throwableCounter++;
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        collectibleCounter.text = throwableCounter.ToString();

        if (Input.GetButtonDown("Fire1") && throwableCounter > 0) {
            offset = new Vector3(1, 0, 0);
            offset = transform.localScale.x * new Vector3(1,0,0);
            Vector3 throwablePosition = transform.position + offset;

            Instantiate(objectThrown, throwablePosition, transform.rotation);
            throwableCounter--;
        }
        
    }
}
