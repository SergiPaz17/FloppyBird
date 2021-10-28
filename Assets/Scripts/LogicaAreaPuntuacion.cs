using UnityEngine;

public class LogicaAreaPuntuacion : MonoBehaviour
{

    public AudioSource AudioPuntuacion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        LogicaPuntuacion.puntuacion++;

        AudioPuntuacion.Play();
    }
}
