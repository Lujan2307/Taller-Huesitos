using UnityEngine;

public class Huesitos : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Contador_Huesos.instance.SumarHuesos();
            Destroy(gameObject);
        }
    }


}  
