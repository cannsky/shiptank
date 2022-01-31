using UnityEngine;

public class SpawnFireball : MonoBehaviour {

    public GameObject fireball;

    public Transform player;

    public Vector3 spawnPosition;

    public Quaternion spawnRotation;

    public float speed;

    void Update() {

      if(Input.GetKeyDown("space")) SpawnObject();

    }

    Vector3 SpawnInfo() {

      float x = Mathf.Cos(player.eulerAngles.z * Mathf.Deg2Rad);

      float y = Mathf.Sin(player.eulerAngles.z * Mathf.Deg2Rad);

      return new Vector3(x, y, 0f);

    }

    void MoveObject(GameObject gameObject, Vector3 spawnPosition) {

      gameObject.GetComponent<Rigidbody>().AddForce(spawnPosition * 20 * speed * Time.deltaTime);

    }

    void SpawnObject() {

      spawnPosition = SpawnInfo() * 1f;

      GameObject gameObject = (GameObject)Instantiate(fireball, spawnPosition, spawnRotation);

      MoveObject(gameObject, spawnPosition);

    }

}
