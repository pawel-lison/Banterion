using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickTime : MonoBehaviour {
    public Image SpriteUp;
    public Image SpriteDown;
    public Image SpriteLeft;
    public Image SpriteRight;
    public Image SpriteBG;
    public GameObject car;
    public GameObject QTE;
    private string keyExpected;
    private int n;
    private int entry = 0;
    public int counter = 0;
    private bool wasCorrect = false;

    private void Start() {
        SpriteUp.enabled = false;
        SpriteDown.enabled = false;
        SpriteLeft.enabled = false;
        SpriteRight.enabled = false;
        SpriteBG.enabled = false;
        keyExpected = null;
        wasCorrect = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (entry == 0) {
            QTE.SetActive(true);
            SpriteBG.enabled = true;
            GenKey();
            entry++;
        }
        else {
            QTE.SetActive(false);
            SpriteBG.enabled = false;
            counter = wasCorrect == true ? counter + 1 : 0;
            Debug.Log(counter);

            if (counter >= 5) {
                Start();
                enabled = false;
            }

            Start();
            entry--;
        }

    }

    private void Update() {
        if (Input.anyKeyDown) {
            if (Input.GetButtonDown(keyExpected)) {
                wasCorrect = true;
                Debug.Log("correct");
            }
            else {
                wasCorrect = false;
                Debug.Log("incorrect");
            }
        }
    }

    IEnumerator GetKey() {

        if (Input.GetButtonDown(keyExpected)) {
            Start();
            Debug.Log("correct");
        }
        yield return new WaitForSeconds(1);

    }
    private void GenKey() {
        n = Random.Range(0, 4);

        switch (n) {
            case 0:
                SpriteUp.enabled = true;
                keyExpected = "up";
                break;
            case 1:
                SpriteDown.enabled = true;
                keyExpected = "down";
                break;
            case 2:
                SpriteLeft.enabled = true;
                keyExpected = "left";
                break;
            case 3:
                SpriteRight.enabled = true;
                keyExpected = "right";
                break;
        }
    }

    public int GetCounter() {
        return counter;
    }

    public void SetCounter(int c) {
        counter = c;
    }
}