using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{
    public float hungerMultiplier;

    public Slider hungerSlider;

    public float hunger, maxHunger;



    public void Eat(float amount, bool overeat)
    {
        if (!overeat && amount > maxHunger)
            return;

        hunger = overeat ? hunger + amount : Mathf.Min(hunger + amount, maxHunger);

    }

    public void Update()
    {
        hunger -= Time.deltaTime / hungerMultiplier;
        hungerSlider.maxValue = maxHunger;
        hungerSlider.value = hunger;
   
        if (hunger <= 0f)
        {
            Debug.Log("has died of starvation");
        }
    }




}
