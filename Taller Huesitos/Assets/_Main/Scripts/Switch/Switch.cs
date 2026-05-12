using UnityEngine;

public class Switch : MonoBehaviour
{
    public int entero;
    // Start is called before the first frame update
    void Start()
    {
        entero = 0;
        EstadosDelJuego(5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EstadosDelJuego(int numero)
    {
        switch (numero)
        {
            case 0:
                //describo la accion
                break;
            case 1:
                //describo la accion
                break;
            case 2:
                //describo la accion
                break;

            default:
                break;
        }
    }



}
