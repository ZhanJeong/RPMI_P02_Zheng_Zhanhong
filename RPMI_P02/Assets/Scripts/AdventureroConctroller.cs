using UnityEngine;

public class AdventureroConctroller : MonoBehaviour
{
    public GameObject arrow;

    public Transform spawnPoint;

    private float distance;

    private bool shooting;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //InvokeRepeating("InstantiateArrow", 2, 3);
        shooting = false;

        //distance = GetComponent<BoxCollider>().size.z;
    }

    private void Update()
    {
        bool enemyInFront = Physics.Raycast(spawnPoint.position, transform.forward, float.MaxValue, LayerMask.GetMask("Enemies"));

        if (shooting)  // if (shooting == true)
        {
            if (!enemyInFront)
            {
                shooting = false;
                CancelInvoke("InstantiateArrow");              
                //CanceIvoke();
            }
        }

        if (!shooting) // if (shooting == false)
        {
            if (enemyInFront) // if (enemyFront == true)
            {
            shooting = true;
            CancelInvoke("InstantiateArrow");
            //CancelInvoke();
            }

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(spawnPoint.position, 0.2f);
        Gizmos.color = Color.blue;
        Gizmos.DrawRay (spawnPoint.position, distance * transform.forward);
    }
   
    private void InstantiateArrow() 
    {
        Instantiate(arrow, spawnPoint.position, spawnPoint.rotation);
    }

}
