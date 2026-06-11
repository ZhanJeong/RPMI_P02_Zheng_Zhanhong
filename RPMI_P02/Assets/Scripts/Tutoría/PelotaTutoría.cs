using UnityEngine;

public class T : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("empieza a chocar con " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            //Destroy(collision.gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        print("estoy chocando con " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("dejo de chocar con " + collision.gameObject.name);
    }
}
