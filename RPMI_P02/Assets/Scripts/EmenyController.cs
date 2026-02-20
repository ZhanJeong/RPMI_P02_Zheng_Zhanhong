using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EmenyConctroller : MonoBehaviour
{//Incio de la clase EmenyController

    public float speed;

    public int health = 100;

    public Animator animator;

    //Función que se ejercura todos los frames que el script está activo
    void Update()
    {//Incio de la función Update 

        //print("Se ejecuta la función de Undate");
        transform.Translate(0, 0, -speed * Time.deltaTime, Space.World);

    }//Fin de la funcion apdate

    // Función que se ejecuta cuando el objeto choca con otro
    private void OnCollisionEnter(Collision collision)
    {
        print("CHOQUE");
        if (collision.gameObject.CompareTag("DañoArrow"))
        {

            health = health - 25;
            if (health <= 0)
            {
                animator.SetBool("Dead", true);

            }

        }
        // La función de Update se llama un vez por frame 

        void Update()
        {
            //if (!isDead) 
        }
    }
}
    


   