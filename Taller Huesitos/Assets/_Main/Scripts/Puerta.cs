using UnityEngine;

public class Puerta : MonoBehaviour
{
    private Collider2D col;

    void Start()
    {
        col = GetComponent<Collider2D>();
        col.isTrigger = false; // bloqueada al inicio
    }

    public void DesbloquearPuerta()
    {
        col.isTrigger = true;
        print("Puerta desbloqueada 🚪");
    }
}