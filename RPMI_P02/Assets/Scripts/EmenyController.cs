using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem.Processors;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngineInternal;

public class EmenyConctroller : MonoBehaviour
{//Incio de la clase EmenyController
    
    //Velocidad de movimiento del enemigo
    public float speed = 3.0f;

    //Salud del enemigo
    public int health = 100;

    public Animator animator;

    private bool isDead;

    private bool movement;

    private AdventureroConctroller adventurerToAttack;

    private void Start()
    {
        movement = false;
    }

    // La función de Update se llama una vez for frame
    void Update()
    {
        //if (!isDead) 
        if (isDead == false)
        {
            if (movement == true)
            {
                RaycastHit hitInfo;
                if (Physics.Raycast(transform.position, transform.forward, out hitInfo,0.5f, LayerMask.GetMask("Heroes")))
                {
                    if (hitInfo.collider != null)
                    {
                        adventurerToAttack = hitInfo.collider.GetComponent<AdventureroConctroller>();
                    }
                    movement = false;
                }
                //Movimiento del enemigo en el sentido positivo de su eje Z
                transform.Translate(0, 0, speed * Time.deltaTime);
            }
        }
    }

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

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay (transform.position, transform.forward.normalized * 0.5f );
    }
}
    


   