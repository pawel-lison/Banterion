using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCar : MonoBehaviour {

    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private QuickTime qte;
    private StopCar stop;

    // Start is called before the first frame update
    private void Start() {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        qte = GameObject.FindObjectOfType(typeof(QuickTime)) as QuickTime;
        stop = GameObject.FindObjectOfType(typeof(StopCar)) as StopCar;
    }

    // Update is called once per frame
    private void Update() {
        if (transform.position.x < -screenBounds.x * 2) {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (qte.GetCounter() >= 5) {
            Debug.Log("car trigger");
            stop.enabled = true;
            enabled = false;
            qte.SetCounter(0);
        }
    }
}