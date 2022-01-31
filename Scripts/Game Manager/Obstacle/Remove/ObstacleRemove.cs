using UnityEngine;

public class ObstacleRemove : MonoBehaviour {

    public float obstacleRemoveTime;

    void Update() {

      obstacleRemoveTime -= Time.deltaTime;

      if(obstacleRemoveTime <= 0) {

        Destroy(this.gameObject);

      }

    }

}
