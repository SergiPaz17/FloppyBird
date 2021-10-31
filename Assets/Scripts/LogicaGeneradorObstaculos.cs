using UnityEngine;

public class LogicaGeneradorObstaculos : MonoBehaviour
{
    public float intervalo = 1;
    private float tiempoInicial = 0;
    public GameObject obstaculo;
    public float altura;
    public int posicionTuberia;


    public float time;

    public LogicaPersonaje LogicaPersonaje;

    void Start()
    {
        GameObject obstaculoNuevo = Instantiate(obstaculo);
        obstaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-7, 0), 0);
        Destroy(obstaculoNuevo, 10);
    }

    void Update()
    {

        if (tiempoInicial > intervalo)
        {
            posicionTuberia = posicionTuberia + 5;
            GameObject obstaculoNuevo = Instantiate(obstaculo);
            obstaculoNuevo.transform.position = transform.position + new Vector3(posicionTuberia, Random.Range(-7, 0), 0);
            Destroy(obstaculoNuevo, 40);
            tiempoInicial = 0;
        }
        else
        {
            tiempoInicial += Time.deltaTime;
        }
    }
}