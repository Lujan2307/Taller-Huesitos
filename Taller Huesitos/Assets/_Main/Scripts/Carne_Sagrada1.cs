using UnityEngine;

public class Carne : MonoBehaviour
{
    public Game_Manager gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.ObtenerCarne();
            Destroy(gameObject);
        }
    }
}