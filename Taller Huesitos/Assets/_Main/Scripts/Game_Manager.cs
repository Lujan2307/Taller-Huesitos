using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] private int Vida = 3;
    [SerializeField] private Player_Controller Jugador;
    [SerializeField] private UIManager UI_manager;
    [SerializeField] private bool tieneCarne = false;

    void Start()
    {
        UI_manager.ActualizarVida(Vida);
    }

    public void RestarVida(int daño)
    {
        if (Vida <= 0) return;

        Vida -= daño;

        // ❤️ Actualizar corazones
        UI_manager.ActualizarVida(Vida);

        print("Daño recibido: " + daño);

        if (Vida <= 0)
        {
            Destroy(Jugador.gameObject);
            print("GAME OVER");
        }
    }

    public void ObtenerCarne()
{
    tieneCarne = true;
    print("Carne sagrada obtenida 🥩");
}

public bool TieneCarne()
{
    return tieneCarne;
}
}
    
//> <