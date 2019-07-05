using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InCar : MonoBehaviour
{

    public float timeLeft = 12f;


    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0f)
        {
            LoadScene();
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

}
