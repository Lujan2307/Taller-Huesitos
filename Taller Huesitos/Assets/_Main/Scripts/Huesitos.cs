using UnityEngine;

public class Huesitos : MonoBehaviour
{
    [SerializeField] private int valor = 1;
    [SerializeField] private Game_Manager game_Manager;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            game_Manager.SumarHueso(1); 
            Destroy(gameObject); 
        }
    }
}