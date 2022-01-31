using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    void OnCollisionEnter() {

      FindObjectOfType<GameOver>().OnGameOver();

    }

}
