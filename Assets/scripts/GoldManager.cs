using TMPro;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public int power;
    public int powerPrice;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI powerPriceText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 1;
        powerPrice = 10;
    }

    public void ChangeGold()
    {
        goldAmount += power;
        goldText.text = goldAmount.ToString("00");
    }

    public void ChangePower()
    {
        if (goldAmount >= powerPrice
)
        {
            goldAmount -= powerPrice;
            powerPrice = Mathf.CeilToInt(powerPrice * 2f);
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
    }
}