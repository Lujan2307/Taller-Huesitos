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
        // Inicia el Ui para la vida y huesos actuales
        ui_manager.ActualizarVida(vida);
        ui_manager.ActualizarHuesos(sumarHuesos);
    }

    
    public void SumarHueso(int cantidad)
    {
        sumarHuesos += cantidad;
        Debug.Log("Huesos: " + sumarHuesos);

        ui_manager.ActualizarHuesos(sumarHuesos);
    }

    
    public void RestarVida(int cantidad_daño)
    {
        if (vida <= 0) return;

        vida -= cantidad_daño;

        if (vida < 0)
            vida = 0;

        ui_manager.ActualizarVida(vida);

        print("Daño recibido: " + cantidad_daño);

        if (vida <= 0)
        {
            // Detiene la música de fondo (Si existe)
            if (musicaFondo != null)
            {
                musicaFondo.Stop();
            }

            //  Sonido de muerte
            AudioSource.PlayClipAtPoint(sonidoMuerte, Camera.main.transform.position, volumenMuerte);

            Destroy(jugador.gameObject);

            print("Jugador eliminado");
        }
    }

    // curación
    public void SumarVida(int cantidad)
    {
        if (vida >= vidaMaxima) return;

        vida += cantidad;

        if (vida > vidaMaxima)
            vida = vidaMaxima;

        ui_manager.ActualizarVida(vida);

        Debug.Log("Vida curada: " + cantidad);
    }

    // Vida llena
    public bool EstaVidaLlena()
    {
        return vida >= vidaMaxima;
    } 

    // Carne sagrada
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