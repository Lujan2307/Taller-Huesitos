using UnityEngine;

public class Heal : MonoBehaviour
{
    [Header("Configuración")]
    [SerializeField] private Game_Manager gameManager;
    [SerializeField] private int cura = 1;

    [Header("Sonido")]
    [SerializeField] private AudioClip sonidoHeal;
    [SerializeField] private float volumen = 1.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            // 🧠 Solo curar si no está lleno
            if (!gameManager.EstaVidaLlena())
            {
                // ❤️ Curar
                gameManager.SumarVida(cura);

                // 🔊 Sonido
                AudioSource.PlayClipAtPoint(sonidoHeal, transform.position, volumen);

                // ❌ Destruir objeto
                Destroy(gameObject);
            }
        }
    }
}