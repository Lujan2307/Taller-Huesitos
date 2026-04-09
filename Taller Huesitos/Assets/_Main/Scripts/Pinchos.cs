using UnityEngine;

public class Pinchos : MonoBehaviour
{
    [SerializeField] private int daño = 1;
    [SerializeField] private Game_Manager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.RestarVida(daño);
        }
    }
}