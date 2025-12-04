using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public int power;
    public int timeGold;
    public int timeGoldPrice;
    public int powerPrice;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI timeGoldText;
    public TextMeshProUGUI timeGoldPriceText;
    public TextMeshProUGUI powerPriceText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 0;
        powerPrice = 10;
        timeGold = 0;
        timeGoldPrice = 5;
        StartCoroutine(autoGold());
    }

    public void ChangeGold()
    {
        goldAmount += power + 1;
        goldText.text = goldAmount.ToString("00");
    }
    public void launch()
    {
        if (goldAmount >= timeGoldPrice)
        {
            goldAmount -= timeGoldPrice;
            timeGoldPrice = Mathf.CeilToInt(timeGoldPrice * 1.7f);
            goldText.text = goldAmount.ToString("00");

            timeGold += 1;
        }
    }

    public void ChangePower()
    {
        if (goldAmount >= powerPrice
)
        {
            goldAmount -= powerPrice;
            powerPrice = Mathf.CeilToInt(powerPrice * 1.5f);
            goldText.text = goldAmount.ToString("00");
            powerText.text = goldAmount.ToString("00");

            power += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        powerText.text = power.ToString("00");
        powerPriceText.text = powerPrice.ToString("00");
        timeGoldPriceText.text = timeGoldPrice.ToString("00");
        timeGoldText.text = timeGold.ToString("00");
    }
    public IEnumerator autoGold()
    {
            while (true)
            {
                goldAmount += timeGold;
                yield return new WaitForSeconds(1);
            }
    }

}