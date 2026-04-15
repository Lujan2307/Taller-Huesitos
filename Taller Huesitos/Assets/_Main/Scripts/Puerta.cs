using UnityEngine;
using TMPro;

public class Puerta : MonoBehaviour
{
    public Game_Manager gameManager;
    public Flores flores;
    public GameObject jugador;
    public TextMeshProUGUI textoWin;

    private bool activada = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && gameManager.TieneCarne())
        {
            if (!activada)
            {
                flores.ActivarFlores();

                jugador.SetActive(false); // desaparece jugador
                Debug.Log("Activando WIN");
                textoWin.gameObject.SetActive(true); // aparece WIN

                activada = true;
            }
        }
    }
}