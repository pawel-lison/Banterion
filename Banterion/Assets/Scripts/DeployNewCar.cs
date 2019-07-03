using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployNewCar : MonoBehaviour {

    public GameObject carPrefab;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(CarTraffic());
    }

    private void spawnCars() {
        GameObject a = Instantiate(carPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 1.5f, -2.8f);
    }

    IEnumerator CarTraffic() {
        while (true) {
            yield return new WaitForSeconds(Random.Range(0.4f, 3.2f));
            spawnCars();
        }
    }
}
