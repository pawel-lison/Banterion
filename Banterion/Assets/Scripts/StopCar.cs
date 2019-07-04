using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCar : MonoBehaviour {

    private float speed_x = 7.0f;
    private float speed_y = 0;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start() {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed_x, 0);
        Debug.Log("stop");
    }

    // Update is called once per frame
    private void Update() {
        if (speed_x > 0) {
            speed_y = speed_x > 3.5f ? speed_y + 0.02f : speed_y - 0.02f;
            speed_x = 0;
            rb.velocity.Set(-speed_x, speed_y);
        }
    }

}
