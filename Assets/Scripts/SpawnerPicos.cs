using UnityEngine;

public class SpawnerPicos : MonoBehaviour
{
    public GameObject picoPrefab;
    public float tiempoEntrePicos = .5f;

    public float limiteIzquierda = 3f;
    public float limiteDerecha = 3f;
    public float alturaAparicion = 6f;

    void Start()
    {
        //invokeRepeating se utiliza para que Unity ejecute el método CrearPico() continuamente.
        InvokeRepeating(
            nameof(CrearPico),
            1f,
            tiempoEntrePicos
        );
        
        
    }

    void CrearPico()
    {
        float posicionX = Random.Range(
            limiteIzquierda, 
            limiteDerecha
        );

        Vector3 posicion = new Vector3 (
            posicionX,
            alturaAparicion,
            0f
        );

        Instantiate(picoPrefab, posicion, Quaternion.identity);

        //Instantiate -> crea una copia del objeto (pico)
        //picoPrefab -> objeto que se va a copiar
        //posicion -> Indica dónde aparecerá el nuevo pico
        //Quaternion.identity -> el pico aparecerá sin rotación adicional,
    }
    
}
