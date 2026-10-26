using UnityEngine;

public class ControlPelota : MonoBehaviour
{
    public float velocidadHorizontal = 3f;
    public float fuerzaImpulso = 4f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.linearVelocity = new Vector2(
            velocidadHorizontal,
            0f
        );
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(
                Vector2.up * fuerzaImpulso,
                ForceMode2D.Impulse
            );
        }
        
    }

    //detectar cuando la pelota colisiona con otro objeto
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            Debug.Log("La pelota toco el suelo");
        }
    }
}