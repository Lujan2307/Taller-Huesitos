using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] private int vida = 3;
    [SerializeField] private Player_Controller jugador;
    [SerializeField] private UIManager ui_manager;
    [SerializeField] private bool tieneCarne = false;
    [SerializeField] private int sumarHuesos = 1;   

    void Start()
    {
        ui_manager.ActualizarVida(vida);
    }

    public void SumarHueso(int Cantidad)
    {
        sumarHuesos += Cantidad;
        Debug.Log("Huesos: " + sumarHuesos);

        // Opcional: actualizar UI
        ui_manager.ActualizarHuesos(sumarHuesos);
    }

    public void RestarVida(int cantidad_daño)
    {

        if (vida <= 0) return;

        vida -= cantidad_daño;

        // ❤️ Actualizar corazones
        ui_manager.ActualizarVida(vida);

        print("Daño recibido: " + cantidad_daño);

        if (vida <= 0)
        {
            Destroy(jugador.gameObject);
            print("GAME OVER");
        }
    }

    public void ObtenerCarne()
{
    tieneCarne = true;
    print("Carne sagrada obtenida ");
}

public bool TieneCarne()
{
    return tieneCarne;
}
}
    
//> <