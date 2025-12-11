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
    public int timeGoldUP;
    public int timeGoldUPPrice;
    public int powerPrice;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI timeGoldText;
    public TextMeshProUGUI timeGoldPriceText;
    public TextMeshProUGUI timeGoldUPText;
    public TextMeshProUGUI timeGoldUPPriceText;
    public TextMeshProUGUI powerPriceText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 0;
        powerPrice = 25;
        timeGold = 0;
        timeGoldPrice = 100;
        timeGoldUP = 0;
        timeGoldUPPrice = 1000;
        StartCoroutine(autoGold());
        StartCoroutine(autoGoldUP());
    }

    public void ChangeGold()
    {
        goldAmount += power + 1;
    }
    public void LaunchCoroutine()
    {
        if (goldAmount >= timeGoldPrice)
        {
            goldAmount -= timeGoldPrice;
            timeGoldPrice = Mathf.CeilToInt(timeGoldPrice * 1.2f);

            timeGold += 5;
        }
    }
    public void LaunchCoroutineUP()
    {
        if (goldAmount >= timeGoldUPPrice)
        {
            goldAmount -= timeGoldUPPrice;
            timeGoldUPPrice = Mathf.CeilToInt(timeGoldUPPrice * 1.2f);

            timeGoldUP += 15;
        }
    }

    public void ChangePower()
    {
        if (goldAmount >= powerPrice
)
        {
            goldAmount -= powerPrice;
            powerPrice = Mathf.CeilToInt(powerPrice * 1.2f);

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
        timeGoldUPPriceText.text = timeGoldUPPrice.ToString("00");
        timeGoldUPText.text = timeGoldUP.ToString("00");
        goldText.text = goldAmount.ToString("00");
    }
    public IEnumerator autoGold()
    {
            while (true)
            {    
                yield return new WaitForSeconds(10);
                goldAmount += timeGold;
            }
    }
    public IEnumerator autoGoldUP()
    {
            while (true)
            {
            yield return new WaitForSeconds(1);
                goldAmount += timeGoldUP;
            }
    }

}