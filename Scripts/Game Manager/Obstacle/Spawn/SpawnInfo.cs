using UnityEngine;

public class SpawnInfo : MonoBehaviour {

    public Vector3 GetSpawnInfo() {

      float x = Random.Range(0,21);

      float y = Mathf.Sqrt((20 * 20) - (x * x));

      float signX = Random.Range(0,2);

      float signY = Random.Range(0,2);

      if(signX == 0) x = -x;

      if(signY == 0) y = -y;

      return new Vector3(x, y, 0f);

    }

}
