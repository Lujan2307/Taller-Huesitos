using UnityEngine;
using TMPro;



public class Switch : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI textoResultante;

    void Start()
    {

        EstadosDelJuego(3);
    }
    void Update()
    {

    }

    public void EstadosDelJuego(int numero)
    {
        switch (numero)
        {
            case 0:
                textoResultante.text = "Me inclino hacia el, lo abrazo y lo beso.";

                break;

            case 1:
                textoResultante.text = "Retrocedo unos pasos, tomo impulso, corro y, de una patada, lo mando a volar.";

                break;

            case 2:
                textoResultante.text = "Me pongo tímide, uwu, y echo a correr, ñya.";

                break;

            default:
                textoResultante.text = "Te encontraste a tu Crush, ¿qué vas a hacer?";

                break;

        }
    }
}