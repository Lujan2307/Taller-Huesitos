using UnityEngine;
using TMPro;

public class Switch : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI texto;

    void Start()
    {
        EstadosDelJuego(3);
    }

    public void EstadosDelJuego(int numero)
    {
        switch (numero)
        {
            case 0:
                texto.text = "Me acerco con confianza… tropiezo, caigo y termino abrazándola igual.";
                break;

            case 1:
                texto.text = "Retrocedo unos pasos, corro épicamente… y me estrello contra una pared.";
                break;

            case 2:
                texto.text = "Me pongo muy nervioso, digo una bobada para romper el hielo, hago contacto visual y me desintegro.";
                break;

        }
    }


    public void Opcion0()
    {
        EstadosDelJuego(0);
    }

    public void Opcion1()
    {
        EstadosDelJuego(1);
    }

    public void Opcion2()
    {
        EstadosDelJuego(2);
    }
}