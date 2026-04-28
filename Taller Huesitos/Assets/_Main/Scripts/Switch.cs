 using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EstadoDelJuego(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EstadoDelJuego()
    {
        print("El estado del juego ha cambiado");
    }
}
