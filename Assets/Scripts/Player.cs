using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public static Player instance;
    private float _horizontal;
    private float _moveSpeed;
    public Rigidbody2D rb;

    void Start() {
        if (instance == null) {
            instance = this;
        }

        rb = GetComponent<Rigidbody2D>();
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

        rb.velocity = new Vector2(Input.acceleration.x * _moveSpeed, rb.velocity.y);
    }
}
