using UnityEngine;

public class DestruirPlayer : MonoBehaviour
{
    //script para destruir el 
    // jugador cuando se colisiona con un pico

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pico"))
        {
            Time.timeScale = 0f;    //detiene el tiempo del juego
            Destroy(gameObject); //destruye la bolita
        }
    }
}
