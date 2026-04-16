using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [Header("Vida")]
    [SerializeField] private int vida = 3;
    [SerializeField] private int vidaMaxima = 3;

    [Header("Referencias")]
    [SerializeField] private Player_Controller jugador;
    [SerializeField] private UIManager ui_manager;

    [Header("Estado")]
    [SerializeField] private bool tieneCarne = false;
    [SerializeField] private int sumarHuesos = 0;

    [Header("Audio Muerte")]
    [SerializeField] private AudioSource musicaFondo;
    [SerializeField] private AudioClip sonidoMuerte;
    [SerializeField] private float volumenMuerte = 2f;

    void Start()
    {
        // Inicializar UI
        ui_manager.ActualizarVida(vida);
        ui_manager.ActualizarHuesos(sumarHuesos);
    }

    // 🦴 HUESOS
    public void SumarHueso(int cantidad)
    {
        sumarHuesos += cantidad;
        Debug.Log("Huesos: " + sumarHuesos);

        ui_manager.ActualizarHuesos(sumarHuesos);
    }

    // 💔 DAÑO
    public void RestarVida(int cantidad_daño)
    {
        if (vida <= 0) return;

        vida -= cantidad_daño;

        if (vida < 0)
            vida = 0;

        ui_manager.ActualizarVida(vida);

        Debug.Log("Daño recibido: " + cantidad_daño);

        if (vida <= 0)
        {
            // ⛔ Detener música
            if (musicaFondo != null)
            {
                musicaFondo.Stop();
            }

            // 🔊 Sonido de muerte
            AudioSource.PlayClipAtPoint(sonidoMuerte, Camera.main.transform.position, volumenMuerte);

            // 👤 Destruir jugador (opcional delay)
            Destroy(jugador.gameObject);

            Debug.Log("Jugador eliminado");
        }
    }

    // ❤️ CURACIÓN
    public void SumarVida(int cantidad)
    {
        if (vida >= vidaMaxima) return;

        vida += cantidad;

        if (vida > vidaMaxima)
            vida = vidaMaxima;

        ui_manager.ActualizarVida(vida);

        Debug.Log("Vida curada: " + cantidad);
    }

    // ❓ VIDA LLENA
    public bool EstaVidaLlena()
    {
        return vida >= vidaMaxima;
    }

    // 🍖 CARNE
    public void ObtenerCarne()
    {
        tieneCarne = true;
        Debug.Log("Carne sagrada obtenida");
    }

    public bool TieneCarne()
    {
        return tieneCarne;
    }
}
    
//> <