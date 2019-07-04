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

    private void Start() {
        SpriteUp.enabled = false;
        SpriteDown.enabled = false;
        SpriteLeft.enabled = false;
        SpriteRight.enabled = false;
        SpriteBG.enabled = false;
        keyExpected = null;
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
            Start();
            entry--;
        }

    }

    private void Update() {
        if (Input.anyKeyDown) {
            if (Input.GetButtonDown(keyExpected)) {
                //start coroutine keypressing
                Start();
                Debug.Log("correct");
            }
            else {
                Debug.Log("incorrect");
                Start();
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
    public void GenKey() {
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
        /*
        if(Input.anyKeyDown){
            if (Input.GetButtonDown("up")) {
                    SpriteUp.enabled = false;
                    SpriteBG.enabled = false;
                    Debug.Log("correct");
                    return;
                }
                Debug.Log("incorrect");
            }
        if (Input.GetButtonDown("down")) {
                    SpriteDown.enabled = false;
                    SpriteBG.enabled = false;
                    Debug.Log("correct");
                    return;
                }
                Debug.Log("incorrect");

        if (Input.GetButtonDown("left")) {
                    SpriteLeft.enabled = false;
                    SpriteBG.enabled = false;
                    Debug.Log("correct");
                    return;
                }
                Debug.Log("incorrect");

        if (Input.GetButtonDown("right")) {
                    SpriteRight.enabled = false;
                    SpriteBG.enabled = false;
                    Debug.Log("correct");
                    return;
                }
                Debug.Log("incorrect");
        */
    }
}