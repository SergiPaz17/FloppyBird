using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
{
    public GameObject canvasPerder;
    public AudioSource audio;
    public GameObject Gameover;
    public GameObject Jugar;
    public GameObject Titulo;
    public GameObject CanvasPuntuacion;
    public GameObject reiniciar;
    public GameObject Score;
    public GameObject Puntuacion;
    public GameObject Bronze;
    public GameObject Plata;
    public GameObject Oro;
    public GameObject FondoNoche;
    public GameObject FondoDia;
    public GameObject BotonResume;
    public GameObject CosaRara;
    public GameObject Flecha;
    public GameObject Dedo;
    public GameObject tap2;
    public GameObject FloppyFantasma;

    private float tiempo = 0;


    private static int puntuacion;

    public TMP_Text puntuacionTMP;

    public LogicaPuntuacion LogicaPuntuacion;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void Perder()
    {

        puntuacion = LogicaPuntuacion.puntuacion;
        puntuacionTMP.SetText(puntuacion.ToString());

        canvasPerder.SetActive(true);
        Time.timeScale = 0;
        Gameover.SetActive(true);
        reiniciar.SetActive(true);
        CanvasPuntuacion.SetActive(false);
        Score.SetActive(true);
        Puntuacion.SetActive(true);

        if(puntuacion <= 8)
        {
            Bronze.SetActive(true);
        }
        else if(puntuacion >= 9 && puntuacion <= 16)
        {
            Plata.SetActive(true);
        }else if (puntuacion >= 16)
        {
            Oro.SetActive(true);
        }

        audio.Stop();

        
    }

    public void Play()
    {
        Time.timeScale = 1;
        Jugar.SetActive(false);
        Titulo.SetActive(false);
        CanvasPuntuacion.SetActive(true);
        BotonResume.SetActive(false);
        tap2.SetActive(false);
        FloppyFantasma.SetActive(false);
        CosaRara.SetActive(false);
        Flecha.SetActive(false);
        Dedo.SetActive(false);

    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }

    public void Pausar()
    {
        Time.timeScale = 0;
        BotonResume.SetActive(true);

    }

    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= 10)
        {
            FondoDia.SetActive(false);
            FondoNoche.SetActive(true);
            
        }

    }


}
