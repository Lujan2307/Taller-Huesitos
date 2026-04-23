using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [Header("Movimiento")]
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float fuerzaSalto = 7f;
    
    [Header("Referencias")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Game_Manager gameManager;
    [SerializeField] Animator animator;
    private const string STRING_VELOCIDAD_HORIZONTAL = "velocidadhorizontal";
    private const string STRING_EN_SUELO = "Elsuelo";

    [Header("Visual")]
    [SerializeField] private Transform visual; 
    [Header("Sonido")]
    [SerializeField] private AudioSource audioPasos;

    [Header("Sonido de Salto")]
    [SerializeField] private AudioClip sonidoSalto;
    [SerializeField] private float volumenSalto = 1.5f;

    [Header("Estado")]
    [SerializeField] private bool Suelo;
    private float movimientoX;

    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimientoX = Input.GetAxis("Horizontal");

        
        if (movimientoX != 0 && Suelo)
        {
            if (!audioPasos.isPlaying) //Sonido de pasos
            {
                audioPasos.Play();
            }
        }
        else
        {
            audioPasos.Stop();
        }

        
        if (movimientoX != 0)
{
    Vector3 escalaActual = visual.localScale;

    escalaActual.x = Mathf.Abs(escalaActual.x) * (movimientoX > 0 ? 1 : -1); //Gira Visualmwnte el jugador sin modificar su escala

    visual.localScale = escalaActual;
}

        //  SALTO
        if (Input.GetKeyDown(KeyCode.Space) && Suelo)
        {
            AudioSource.PlayClipAtPoint(sonidoSalto, Camera.main.transform.position, volumenSalto);
            
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movimientoX * velocidad, rb.linearVelocity.y);
        ControlarAnimaciones();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            Suelo = true;
        }

        if (collision.gameObject.CompareTag("Enemigo"))
        {
            gameManager.RestarVida(0);
        }
    }

        private void ControlarAnimaciones()
        {
         animator.SetFloat(STRING_VELOCIDAD_HORIZONTAL, Mathf.Abs(rb.linearVelocity.x));
         animator.SetBool(STRING_EN_SUELO, Suelo);
        }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            Suelo = false;
        }
    }
}