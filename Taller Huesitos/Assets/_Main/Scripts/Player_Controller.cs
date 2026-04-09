using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [Header("Movimiento")]
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float fuerzaSalto = 7f;

    [Header("Referencias")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Game_Manager gameManager;

    [Header("Estado")]
    [SerializeField] private bool Suelo;
    private float movimientoX;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimientoX = Input.GetAxis("Horizontal");

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && Suelo)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0); // evita saltos acumulados
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movimientoX * velocidad, rb.linearVelocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            Suelo = true;
        }

        // 🔥 EJEMPLO DE DAÑO
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            gameManager.RestarVida(10);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            Suelo = false;
        }
    }
}