using UnityEngine;
using System.Collections; // Necesario para usar Corrutinas

public class Pinchos : MonoBehaviour
{
    [SerializeField] private int daño = 0;
    [SerializeField] private Game_Manager gameManager;
    
    // Nueva variable para controlar el estado
    private bool puedeHacerDaño = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && puedeHacerDaño)
        {
            StartCoroutine(AplicarDaño());
        }
    }

    IEnumerator AplicarDaño()
    {
        puedeHacerDaño = false; // Desactiva el daño temporalmente
        
        gameManager.RestarVida(daño);

        // Espera medio segundo antes de permitir que este pincho vuelva a hacer daño
        yield return new WaitForSeconds(0.5f); 
        
        puedeHacerDaño = true;
    }
}