using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;
    private Rigidbody2D enemyRigidBody;

    void Awake() {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        enemyRigidBody.AddForce(Vector2.left * xForce);
        enemyRigidBody.AddForce(Vector2.right * xForce);
    }


    private void OnCollisionEnter2D(Collision2D collision) {

        if (xDirection <= 5) {
            xDirection *= -1.7f;
        } else {
            xDirection = 5;
            xDirection *= -1;
        }
        
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Enemy") {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }

        if (collision.gameObject.tag == "Player") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
