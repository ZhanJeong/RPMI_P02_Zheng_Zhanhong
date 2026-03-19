using UnityEngine;

public class CollectableController: MonoBehaviour
{

    // Función que se ejecuta cuando el objeto choca con otro
    private void OnCollisionEnter(Collision collision)
    {
        print("CHOQUE");
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            Destroy(gameObject);
            //Destroy(collision.gameObject);
        }
        
        


    }
}
