using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public string escenaTexto;

    public UIManger UI;

    private int escena = 0;

    private void Start()
    {
        EscenaIntro(escenaTexto);
    }

    public void EscenaIntro(string escenaTexto)
    {
        switch (escena)
        {
            // Inicio
            case 0:

                UI._textDialogo.text = "Te encontraste con tu crush, ¿qué vas a hacer?";

                UI._textButton[0].text = "Saludar";
                UI._textButton[1].text = "Hablar";
                UI._textButton[2].text = "Correr";

                break;

            // Desarrollo
            case 1:

                UI._textDialogo.text = "Comenzaron a hablar, ¿qué harás ahora?";

                UI._textButton[0].text = "Pedir número";
                UI._textButton[1].text = "Despedirse";
                UI._textButton[2].text = "Irse";

                break;

            // Desenlace
            case 2:

                UI._textDialogo.text = "¡Aceptó salir contigo! Final feliz";

                UI._textButton[0].text = "";
                UI._textButton[1].text = "";
                UI._textButton[2].text = "";

                break;
        }
    }

    public void ElegirOpcion(int opcion)
    {
        if (escena == 0)
        {
            if (opcion == 0 || opcion == 1)
                escena = 1;
            else
                escena = 2;
        }

        else if (escena == 1)
        {
            escena = 2;
        }

        EscenaIntro(escenaTexto);
    }
}