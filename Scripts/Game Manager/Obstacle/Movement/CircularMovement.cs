using UnityEngine;

public class CircularMovement : MonoBehaviour {

    public float counter = 0;

    public float diameterCounter = 0;

    public float speed = 0.1f;

    public float diameter = 20;

    float x, y, z;

    void Start() {

      x = transform.position.x;

      y = transform.position.y;

      z = 0;

    }

    void Update() {

      counter += Time.deltaTime;

      diameterCounter += Time.deltaTime;

      x = (Mathf.Cos(counter) * diameter);

      y = (Mathf.Sin(counter) * diameter);

      if(diameterCounter >= 0.01f) {

        diameter -= (1f * Time.deltaTime);

        diameterCounter = 0;

      }

      transform.position = new Vector3(x, y, z);

    }

}
