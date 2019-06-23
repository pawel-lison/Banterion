using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Money : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    public int money;

    void Start()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = money.ToString();

        if (money <= 0)
        {
            Debug.Log("has died of lack of money");
        }
    }
}
