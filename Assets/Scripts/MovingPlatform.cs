using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    [SerializeField] private float _moveSpeed = 2f;
    private bool moveRight = true;
    [SerializeField] private float _jumpForce = 10f;
    [SerializeField] private Transform _deadZone;
    [SerializeField] private AudioSource _jumpSound;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.relativeVelocity.y <= 0f) {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null) {
                Vector2 velocity = rb.velocity;
                velocity.y = _jumpForce;
                rb.velocity = velocity;
                _jumpSound.Play();
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
            newPosition.x += _moveSpeed * Time.deltaTime;
        } else {
            newPosition.x -= _moveSpeed * Time.deltaTime;
        }

        if (newPosition.x >= 1.7f) {
            moveRight = false;
        } else if (newPosition.x <= -1.7f) {
            moveRight = true;
        }

        transform.position = newPosition;
    }
}
