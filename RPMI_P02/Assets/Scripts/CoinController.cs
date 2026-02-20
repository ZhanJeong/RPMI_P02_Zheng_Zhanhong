using TMPro;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public Inventory inventory;
    private TextMeshProUGUI coinsText;

    private void Start() 
    {
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        coinsText = GameObject.Find("Coins Counter").GetComponent<TextMeshProUGUI>();
    }
        
        private void OnMouseDown()
    {
        inventory.AddCoins(1);
        Destroy(gameObject);
    }
}
