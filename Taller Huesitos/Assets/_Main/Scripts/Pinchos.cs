using UnityEngine;
using System.Collections;

public class Pinchos : MonoBehaviour
{
    [SerializeField] private int daño = 1;
    [SerializeField] private Game_Manager gameManager;

    [Header("Sonido")]
    [SerializeField] private AudioClip sonidoDaño;
    [SerializeField] private float volumen = 5f;

    private bool puedeHacerDaño = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && puedeHacerDaño)
        {
            StartCoroutine(AplicarDaño(collision.transform));
        }
    }

    IEnumerator AplicarDaño(Transform playerTransform)
    {
        puedeHacerDaño = false;

        // 🔊 Sonido de daño en la posición del jugador
        AudioSource.PlayClipAtPoint(sonidoDaño, playerTransform.position, volumen);

        // 💔 Aplicar daño
        gameManager.RestarVida(daño);

        yield return new WaitForSeconds(0.5f);

        puedeHacerDaño = true;
    }
}