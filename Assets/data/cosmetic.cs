using UnityEngine;

[CreateAssetMenu(fileName = "cosmetic", menuName = "Scriptable Objects/cosmetic")]
public class cosmetic : ScriptableObject
{
    public GoldManager myGoldManager;
    public int cosmeticPrice;
    public int cosmeticSprit;

    public void addCosmetic()
    {
         if (myGoldManager.goldAmount >= cosmeticPrice)
        {
            myGoldManager.goldAmount -= cosmeticPrice;
            
        }
    }
}
