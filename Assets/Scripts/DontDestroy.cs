using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    public ControladorEscena Escena;
    public int x;

    void Update()
    {
        
        Escena.GuardarPuntuacionMaxima();
    }


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


}
