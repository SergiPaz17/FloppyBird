using UnityEngine;
using TMPro;

public class LogicaPuntuacion : MonoBehaviour
{

    public static int puntuacion = 0;

    // Start is called before the first frame update
    void Start()
    {
        puntuacion = 0;
    }
    
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = puntuacion.ToString();
    }
}
