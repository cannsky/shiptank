using UnityEngine;

public class GameOver : MonoBehaviour {

    public GameObject gameOverUI;

    public GameObject scoreText;

    public void OnGameOver() {

      gameOverUI.SetActive(true);

      scoreText.SetActive(false);

      FindObjectOfType<SpawnFireball>().enabled = false;

      FindObjectOfType<PlayerMovement>().enabled = false;

    }

}
