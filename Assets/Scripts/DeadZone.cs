using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour {
    [SerializeField] private Transform _simplePlatform;
    [SerializeField] private Transform _player;

    void Start() {
        
    }

    void Update() {
        
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.name == "Player") {
            SceneManager.LoadScene(0);
        }
    }
}
