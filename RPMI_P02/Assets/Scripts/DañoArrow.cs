using UnityEngine;



public class ArrowController : MonoBehaviour
{
    public float speed = 3.0f;

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
    void Update()
    {
        //Movimiento del enemigo en el sentido positivo de su eje Z
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}