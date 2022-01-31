using UnityEngine;

public class FireballRemove : MonoBehaviour {

    public float fireballRemoveTime;

    void Update() {

      fireballRemoveTime -= Time.deltaTime;

      if(fireballRemoveTime <= 0) {

        Destroy(this.gameObject);

      }

    }

}
