using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    void Update() {

      this.transform.Rotate(new Vector3(0f, 0f, - Input.GetAxis("Horizontal")) * Time.deltaTime * speed);

    }
}
