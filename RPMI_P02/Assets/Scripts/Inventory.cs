using TMPro;
using UnityEngine;

public enum AdventurerType
{
    Barbarian, Druid, Engineer
}

public class Inventory : MonoBehaviour
{
    public int coins;
    public TextMeshProUGUI coinsText;

    public int enemies;

    public AdventurerType adventureToSpawn;

    //private void Update()
    //{
    //   coinText.text = coins.ToString
    //}

    private void Update()
    {
        coinsText.text = coins.ToString();
    }

    public void AddCoins(int coinsToAdd)
    {
        //coins ++;
        //coins = coins + 1;
        coins = coinsToAdd;

        coinsText.text = coins.ToString();
        coinsText.fontSize = 18;
    }





}






