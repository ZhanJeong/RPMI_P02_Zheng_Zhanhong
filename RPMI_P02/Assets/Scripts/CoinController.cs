using TMPro;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public Inventory inventory;
   
    private void Start() 
    {
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();   
    }
        
        private void OnMouseDown()
    {
        inventory.AddCoins(1);
        Destroy(gameObject);
    }
}
