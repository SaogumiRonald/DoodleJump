using UnityEngine;

public class BreakingPlatform : MonoBehaviour {
    public Animator platformAnimator;
    [SerializeField] public Transform _deadZone;

    void Start() {
        if (platformAnimator == null) {
            platformAnimator = GetComponent<Animator>();
        }
    }

    void Update() {
        if (transform.position.y < _deadZone.position.y) {
            float RandX = UnityEngine.Random.Range(-1.7f, 1.7f);
            float RandY = UnityEngine.Random.Range(transform.position.y + 10, transform.position.y + 12);

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            platformAnimator.SetTrigger("Break");
        }
    }
}
