using UnityEngine;

public class Game_Manager : MonoBehaviour
{
 
    public static Game_Manager instance;

    public int vida = 10;
    public int huesos = 0;
    public bool carneRecogida = false;

    void Awake()
    {
        instance = this;
    }

    public void RecibirDaño(int daño)
    {
        vida -= daño;
        print("Vida: " + vida);

        if (vida <= 0)
        {
            print("Game Over");
        }
    }

    public void SumarHueso()
    {
        huesos++;
        print("Huesos: " + huesos);
    }
}
    
