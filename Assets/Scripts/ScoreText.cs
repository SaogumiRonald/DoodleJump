using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Transform player;          
    public Text scoreText;

    private float playerStartHeight;
    private float playerCurrentHeight;

    void Start() {
        playerStartHeight = player.position.y;
        playerCurrentHeight = player.position.y;
        UpdateScoreText();
    }

    void Update() {
        playerCurrentHeight = Mathf.Max(player.position.y, playerCurrentHeight);

        if (playerCurrentHeight > playerStartHeight) {
            playerStartHeight = playerCurrentHeight;
            UpdateScoreText();
        }
    }

    void UpdateScoreText() {
        int score = Mathf.FloorToInt(playerStartHeight);
        scoreText.text = "Score: " + score.ToString();
    }
}
