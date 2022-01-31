using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

    public int score;

    public Text scoreText;

    public void IncreaseScore() {

      score++;

    }

    void Update() {

      scoreText.text = score.ToString();

    }

}
