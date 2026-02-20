using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject adventurer;
    public Transform spawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }

    private void OnMouseDown()
    {
        print("spawn");
        Debug.Log("spawn");

        Instantiate(adventurer, spawnPoint.position,spawnPoint.rotation);
    }
}
