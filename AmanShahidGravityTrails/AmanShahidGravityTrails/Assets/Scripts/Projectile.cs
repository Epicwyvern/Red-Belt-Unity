using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;
    public GameObject exit;
    void Start()
    {
        exit = GameObject.FindGameObjectWithTag("Exit");
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
    }

    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
        gameObject.transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z - 5);
        Invoke("DestroyThrowable", 5);
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy") {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            exit.GetComponent<Teleport>().enemyCount--;
        }
    }

    private void DestroyThrowable() {
        Destroy(gameObject);
    }
}
