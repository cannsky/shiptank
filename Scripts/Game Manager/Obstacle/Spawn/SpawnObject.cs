using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{

    public void SpawnGameObject(GameObject obstacle, Quaternion spawnRotation, float speed) {

      Vector3 spawnPosition = (Vector3)FindObjectOfType<SpawnInfo>().GetSpawnInfo();

      GameObject gameObject = (GameObject)Instantiate(obstacle, spawnPosition, spawnRotation);

      // FindObjectOfType<MoveObject>().MoveGameObject(gameObject, spawnPosition, speed);

    }
    
}
