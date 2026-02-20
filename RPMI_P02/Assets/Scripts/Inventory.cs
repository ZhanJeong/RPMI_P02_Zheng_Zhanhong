using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int coins;
    public TextMeshProUGUI coinsText;

    //private void Update()
    //

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
    }





}






