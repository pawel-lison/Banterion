using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickTime : MonoBehaviour {
    public string carColor = null;
    private int entry = 0;
    private int counter = 0;

    private void Start() {
        carColor = null;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (entry == 0) {
            carColor = other.name;
            entry++;
        }
        else {
            Start();
            entry--;
        }

    }

    private void Update() {
        
    }

    public int GetCounter() {
        return counter;
    }

    public void SetCounter(int c) {
        counter = c;
    }
}