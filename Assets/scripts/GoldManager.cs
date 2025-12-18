using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public int goldGain;
    public int goldGainPrice;
    public int power;
    public int timeGold;
    public int timeGoldPrice;
    public int timeGoldUP;
    public int timeGoldUPPrice;
    public int timeGoldUP2;
    public int timeGoldUP2Price;
    public int powerPrice;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI timeGoldText;
    public TextMeshProUGUI timeGoldPriceText;
    public TextMeshProUGUI timeGoldUPText;
    public TextMeshProUGUI timeGoldUPPriceText;
    public TextMeshProUGUI timeGoldUP2Text;
    public TextMeshProUGUI timeGoldUP2PriceText;
    public TextMeshProUGUI goldChangeText;
    public TextMeshProUGUI goldChangePriceText;
    public TextMeshProUGUI powerPriceText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goldGain = 1;
        goldGainPrice = 50000;
        power = 0;
        powerPrice = 25;
        timeGold = 0;
        timeGoldPrice = 100;
        timeGoldUP = 0;
        timeGoldUPPrice = 1000;
        timeGoldUP2 = 0;
        timeGoldUP2Price = 10000;
        StartCoroutine(autoGold());
        StartCoroutine(autoGoldUP());
        StartCoroutine(autoGoldUP2());
    }

    public void ChangeGold()
    {
        goldAmount += power + goldGain;
    }
    public void LaunchCoroutine()
    {
        if (goldAmount >= timeGoldPrice)
        {
            goldAmount -= timeGoldPrice;
            timeGoldPrice = Mathf.CeilToInt(timeGoldPrice * 1.5f);

            timeGold += 5;
        }
    }
    public void LaunchCoroutineUP()
    {
        if (goldAmount >= timeGoldUPPrice)
        {
            goldAmount -= timeGoldUPPrice;
            timeGoldUPPrice = Mathf.CeilToInt(timeGoldUPPrice * 1.5f);

            timeGoldUP += 50;
        }
    }
    public void LaunchCoroutineUP2()
    {
        if (goldAmount >= timeGoldUP2Price)
        {
            goldAmount -= timeGoldUP2Price;
            timeGoldUP2Price = Mathf.CeilToInt(timeGoldUP2Price * 1.5f);

            timeGoldUP2 += 100;
        }
    }

    public void ChangePower()
    {
        if (goldAmount >= powerPrice
)
        {
            goldAmount -= powerPrice;
            powerPrice = Mathf.CeilToInt(powerPrice * 1.5f);

            power += 1;
        }
    }

    public void ChangeGoldUP()
    {
        if (goldAmount >= goldGainPrice
)
        {
            goldAmount -= goldGainPrice;

            goldGain += 9;
        }
    }
    // Update is called once per frame
    void Update()
    {
        powerText.text = power.ToString("00");
        powerPriceText.text = powerPrice.ToString("00");
        timeGoldPriceText.text = timeGoldPrice.ToString("00");
        timeGoldText.text = timeGold.ToString("00");
        timeGoldUPPriceText.text = timeGoldUPPrice.ToString("00");
        timeGoldUPText.text = timeGoldUP.ToString("00");
        timeGoldUP2PriceText.text = timeGoldUP2Price.ToString("00");
        timeGoldUP2Text.text = timeGoldUP2.ToString("00");
        goldChangePriceText.text = goldGainPrice.ToString("00");
        goldChangeText.text = goldGain.ToString("00");
        goldText.text = goldAmount.ToString("00");
    }
    public IEnumerator autoGold()
    {
            while (true)
            {    
                yield return new WaitForSeconds(5);
                goldAmount += timeGold * goldGain;
            }
    }
    public IEnumerator autoGoldUP()
    {
            while (true)
            {
            yield return new WaitForSeconds(3);
                goldAmount += timeGoldUP * goldGain;
            }
    }
    public IEnumerator autoGoldUP2()
    {
            while (true)
            {
            yield return new WaitForSeconds(1);
                goldAmount += timeGoldUP2 * goldGain;
            }
    }

}