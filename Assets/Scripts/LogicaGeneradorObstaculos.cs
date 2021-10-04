using UnityEngine;

public class LogicaGeneradorObstaculos : MonoBehaviour
{
    public float intervalo = 1;
    private float tiempoInicial = 0;
    public GameObject obstaculo;
    public float altura;
    public int posicionTuberia;
    private int randomAltura;

    public float time;

    public LogicaPersonaje LogicaPersonaje;

    // Start is called before the first frame update
    void Start()
    {
        GameObject obstaculoNuevo = Instantiate(obstaculo);
        obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(obstaculoNuevo, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (tiempoInicial > intervalo)
        {
            posicionTuberia = posicionTuberia + 5;
            randomAltura = Random.Range(-7, 0);
            GameObject obstaculoNuevo = Instantiate(obstaculo);
            obstaculoNuevo.transform.position = transform.position + new Vector3(posicionTuberia, randomAltura , 0);
            Destroy(obstaculoNuevo, 20);
            tiempoInicial = 0;
        }
        else
        {
            tiempoInicial += Time.deltaTime;
        }
    }
}
