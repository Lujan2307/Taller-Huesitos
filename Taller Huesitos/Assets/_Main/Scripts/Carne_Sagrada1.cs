using UnityEngine;

public class CarneSagrada : MonoBehaviour
{
    [SerializeField] private Puerta puerta;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            puerta.DesbloquearPuerta();
            Destroy(gameObject);
        }
    }
}