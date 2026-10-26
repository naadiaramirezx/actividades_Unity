using UnityEngine;

public class VelocidadPelota : MonoBehaviour
{
    public float velocidadHorizontal = 4f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        //inicia con una velocidad horizontal
        rb.linearVelocity = new Vector2(
            velocidadHorizontal,
            0f  //no se le asigna velocidad vertical
        );
    }
}