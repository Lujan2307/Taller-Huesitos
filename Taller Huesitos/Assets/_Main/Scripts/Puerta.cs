using UnityEngine;
using TMPro;

public class Puerta : MonoBehaviour
{
    [Header("Referencias")]
    public Game_Manager gameManager;
    public Flores flores;
    public GameObject jugador;
    public TextMeshProUGUI textoWin;

    [Header("Audio")]
    [SerializeField] private AudioSource musicaFondo;
    [SerializeField] private AudioClip sonidoPuerta;
    [SerializeField] private float volumen = 2f;

    private bool activada = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && gameManager.TieneCarne())
        {
            if (!activada)
            {
                activada = true;

                // 🌸 Activar flores
                flores.ActivarFlores();

                // ⛔ Detener música
                if (musicaFondo != null)
                {
                    musicaFondo.Stop();
                }

                // 🔊 Sonido de puerta (antes de desactivar jugador)
                AudioSource.PlayClipAtPoint(sonidoPuerta, Camera.main.transform.position, volumen);

                // 👤 Desactivar jugador
                jugador.SetActive(false);

                // 🏆 Mostrar WIN
                Debug.Log("Activando WIN");
                textoWin.gameObject.SetActive(true);
            }
        }
    }
}