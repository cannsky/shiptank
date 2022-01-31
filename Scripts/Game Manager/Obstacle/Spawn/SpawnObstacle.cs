using UnityEngine;

public class SpawnObstacle : MonoBehaviour {

    public GameObject obstacle;

    public GameObject circularObstacle;

    public Quaternion spawnRotation;

    public float speed;

    void Update() {

      int randomNumber = Random.Range(0, 100);

      if(randomNumber == 1) FindObjectOfType<SpawnObject>().SpawnGameObject(circularObstacle, spawnRotation, speed);

    }

}
