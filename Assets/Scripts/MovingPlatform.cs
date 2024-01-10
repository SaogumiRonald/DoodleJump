using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    public float moveSpeed = 2f;
    private bool moveRight = true;
    public float jumpForce = 10f;
    [SerializeField] public Transform _deadZone;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.relativeVelocity.y <= 0f) {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null) {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }

    void Update() {
        MovePlatform();

        if (transform.position.y < _deadZone.position.y) {
            float RandX = UnityEngine.Random.Range(-1.7f, 1.7f);
            float RandY = UnityEngine.Random.Range(transform.position.y + 10, transform.position.y + 12);

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }

    void MovePlatform() {
        Vector3 newPosition = transform.position;

        if (moveRight) {
            newPosition.x += moveSpeed * Time.deltaTime;
        } else {
            newPosition.x -= moveSpeed * Time.deltaTime;
        }

        if (newPosition.x >= 1.7f) {
            moveRight = false;
        } else if (newPosition.x <= -1.7f) {
            moveRight = true;
        }

        transform.position = newPosition;
    }
}
