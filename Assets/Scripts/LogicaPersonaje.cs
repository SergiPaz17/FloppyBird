using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocity = 2f;
    private Rigidbody2D rb;
    public Vector2 posicion;

    public ControladorEscena controladorEscena;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posicion = rb.position;
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        controladorEscena.Perder();
    }
}
