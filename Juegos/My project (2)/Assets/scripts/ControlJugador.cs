using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ControlJugador : MonoBehaviour
{
    //variable del movimiento horizontal del personaje
    public float velocidad = 4f;

    //Variable del salto vertical del personaje
    public float fuerzaSalto = 8f;
    public float longitudRaycast = 0.1f;
    public LayerMask capaSuelo;

    private bool enSuelo;
    private Rigidbody2D rb;
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float velocidadX = 1f *Time.deltaTime*velocidad;

        Vector3 posicion = transform.position;

        transform.position = new Vector3(velocidadX + posicion.x, posicion.y, posicion.z);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, longitudRaycast, capaSuelo);
        enSuelo = hit.collider != null;

        if (enSuelo && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down*longitudRaycast);
    }
}
