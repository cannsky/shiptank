using UnityEngine;

public class MoveObject : MonoBehaviour {

    public void MoveGameObject(GameObject gameObject, Vector3 spawnPosition, float speed) {

      gameObject.GetComponent<Rigidbody>().AddForce(-spawnPosition * speed * Time.deltaTime);

    }

}
