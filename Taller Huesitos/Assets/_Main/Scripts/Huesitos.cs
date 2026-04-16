using UnityEngine;

public class Huesitos : MonoBehaviour
{
    [Header("Configuración")]
    [SerializeField] private int valor = 1;
    [SerializeField] private Game_Manager game_Manager;

    [Header("Sonido")]
    [SerializeField] private AudioSource audioSource; // Necesitamos el componente AudioSource
    [SerializeField] private AudioClip sonidoPickup; 
    [SerializeField] private float volumen = 1f; // Bajado a 1f para evitar saturación

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            RecogerHueso();
        }
    }

    private void RecogerHueso()
    {
        // 1. Lógica de puntos
        if (game_Manager != null)
        {
            game_Manager.SumarHueso(valor);
        }

        // 2. Ejecutar sonido desde el AudioSource propio
        if (audioSource != null && sonidoPickup != null)
        {
            audioSource.PlayOneShot(sonidoPickup, volumen);
        }

        // 3. DESACTIVAR VISUALES Y FÍSICAS
        // Desactivamos el SpriteRenderer para que el hueso desaparezca de la vista
        if (GetComponent<SpriteRenderer>() != null)
            GetComponent<SpriteRenderer>().enabled = false;
        
        // Desactivamos el Collider para que el jugador no lo toque dos veces
        if (GetComponent<Collider2D>() != null)
            GetComponent<Collider2D>().enabled = false;

        // 4. DESTRUIR CON RETRASO
        // El objeto se destruirá después de 2 segundos, dando tiempo al audio
        Destroy(gameObject, 2.0f);
    }
}