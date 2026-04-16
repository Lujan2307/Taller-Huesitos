using UnityEngine;

public class Carne : MonoBehaviour
{
    [Header("Referencias")]
    public Game_Manager gameManager;

    [Header("Sonido")]
    [SerializeField] private AudioClip sonidoPickup;
    [SerializeField] private float volumen = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //  Sonido
            AudioSource.PlayClipAtPoint(sonidoPickup, transform.position, volumen);

         
            gameManager.ObtenerCarne();

            //  Destruir objeto
            Destroy(gameObject);
        }
    }
}