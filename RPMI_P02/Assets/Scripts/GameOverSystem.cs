using UnityEngine;

public class GameOverSystem : MonoBehaviour
{
    public GameObject gameover;
    private void OnCollisionEnter(Collision collision)
    {
        print("CHOQUE");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameover.SetActive(true);
        }
    }
}
