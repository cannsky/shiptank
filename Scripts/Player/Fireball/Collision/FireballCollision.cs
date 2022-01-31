using UnityEngine;

public class FireballCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collisionInfo) {

      if(collisionInfo.collider.tag == "Obstacle") {

        Destroy(collisionInfo.gameObject);

        Destroy(this.gameObject);

        FindObjectOfType<PlayerScore>().IncreaseScore();

      }

    }

}
