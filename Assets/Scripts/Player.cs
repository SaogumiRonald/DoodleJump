using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public static Player instance;
    private float _horizontal;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Rigidbody2D _rb;

    void Start() {
        if (instance == null) {
            instance = this;
        }

        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        if (Application.platform == RuntimePlatform.Android) {
            _horizontal = Input.acceleration.x;
        }

        if (Input.acceleration.x < 0) {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        } else {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        _rb.velocity = new Vector2(Input.acceleration.x * _moveSpeed, _rb.velocity.y);

        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 moveDirection = new Vector2(horizontalInput, 0);
        _rb.velocity = new Vector2(moveDirection.x * _moveSpeed, _rb.velocity.y);
    }
}
