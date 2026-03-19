using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject adventurer;
    public Transform spawnPoint;

    public Inventory inventory;

    private void Start()
    {
        //inventory = GameObject.Find("Inventory").GetComponent<Inventoru>();
    }

    private void OnMouseDown()
    {
        print("spawn");
        Debug.Log("spawn");
        if (inventory.coins >= 5)
        {
            if(inventory.adventureToSpawn == AdventurerType.Barbarian) {

                Instantiate(adventurer, spawnPoint.position, spawnPoint.rotation);
                inventory.AddCoins(-5);
            }
        }
    }
}
