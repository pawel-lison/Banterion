using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Frustration : MonoBehaviour
{
    public Image Frust0;
    public Image Frust1;
    public Image Frust2;
    public Image Frust3;

    public float frustrationMultiplier;

    public Slider frustrationSlider;

    public float hp, maxHp;

    private void Start()
    { 
        Frust0.enabled = false;
        Frust1.enabled = false;
        Frust2.enabled = false;
        Frust3.enabled = false;
    }


    public void Rest(float amount, bool overheal)
    {
        if (!overheal && amount > maxHp)
            return;

        hp = overheal ? hp + amount : Mathf.Min(hp + amount, maxHp);

    }

    public void Update()
    {
        hp -= Time.deltaTime/frustrationMultiplier;
        frustrationSlider.maxValue = maxHp;
        frustrationSlider.value = hp;
 

        if (hp > 40f) {
             Frust0.enabled = true;
             Frust1.enabled = false;
             Frust2.enabled = false;
             Frust3.enabled = false;
            }
        else if (hp > 30f)
        {
            Frust0.enabled = false;
            Frust1.enabled = true;
            Frust2.enabled = false;
            Frust3.enabled = false;
        }
        else if (hp > 20f)
        {
            Frust0.enabled = false;
            Frust1.enabled = false;
            Frust2.enabled = true;
            Frust3.enabled = false;
        }
        else if (hp > 10f)
        {
            Frust0.enabled = false;
            Frust1.enabled = false;
            Frust2.enabled = false;
            Frust3.enabled = true;
        }
        else if (hp <= 0f)
        {
            Debug.Log("has died of frustration");
        }
    }




}
