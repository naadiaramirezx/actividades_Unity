using UnityEngine;

public class MovimientoTransform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidad = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //solo detecta el movimiento horizontal
        float movimiento = Input.GetAxisRaw("Horizontal");
        transform.Translate(
            Vector3.right * movimiento * velocidad * Time.deltaTime
        );
        
    }
}
