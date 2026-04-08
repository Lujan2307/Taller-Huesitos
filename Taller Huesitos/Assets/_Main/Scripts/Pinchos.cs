using Unity.VisualScripting;
using UnityEngine;

public class Pinchos : MonoBehaviour
{
    public int daño = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
    
        if (collision.gameObject.CompareTag("Player"))
        {
            //collision.gameObject.GetComponent<Vida>().RecibirDaño(daño);

        }
            
    
    } 


}  
