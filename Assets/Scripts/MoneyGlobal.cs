using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyGlobal : MonoBehaviour
{
    public GameObject MoneyDisplay;
    public static int Money = 0;

    // Update is called once per frame
    void Update()
    {
        MoneyDisplay.GetComponent<TextMeshProUGUI>().text = "Money: " + Money;
    }
}
