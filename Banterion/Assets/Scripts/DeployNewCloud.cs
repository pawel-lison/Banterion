using System.Collections;
using UnityEngine;

public class DeployNewCloud : MonoBehaviour {
    public GameObject cloudPrefab;
    private Vector2 screenBounds;
    private float u1, u2, randStdNormal, randNormal;

    // Start is called before the first frame update
    void Start() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(CloudySky());
    }

    private void spawnClouds() {
        GameObject a = Instantiate(cloudPrefab) as GameObject;
        a.transform.position = new Vector2(-screenBounds.x * 1.2f, -2.57f);
    }

    IEnumerator CloudySky() {
        
        while (true) {
            u1 = 1.0f - Random.value;
            u2 = 1.0f - Random.value;
            randStdNormal = Mathf.Sqrt(-2 * Mathf.Log(u1)) * Mathf.Sin(2 * Mathf.PI * u2);
            randNormal = 25 + 7 * randStdNormal;

            yield return new WaitForSeconds(randNormal);
            spawnClouds();
        }
    }
}
