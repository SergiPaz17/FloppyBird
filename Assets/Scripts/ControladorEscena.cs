using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public GameObject CanvasSkin;
    public GameObject SkinBoton;
    public GameObject Flappo;
    public GameObject Flappo2;
    public GameObject Flappo3;
    public GameObject BestPuntuacion;
    public GameObject CanvasHighScores;
    public GameObject CanvasNombreJugador;
    public GameObject botonScoreboard;


    private int numeroSkin;
    public TMP_Text HiScore;

    private int puntuacionMaxima;
    private float tiempo = 0;
    public int PuntuacionMaxima;
    public string nombreJugador;

    public InputField NombreJugador;



    public int puntuacion;

    public TMP_Text puntuacionTMP;
    public TMP_Text puntuacionMaximaTPM;

    // Imports de Otros Scripts
    public EscogerSkin Skin;
    public LogicaPuntuacion LogicaPuntuacion;
    public Leadeboardcontroller Leaderboard;


    // Start is called before the first frame update
    void Start()
    {

        //PlayerPrefs.DeleteKey("HiScore");
        nombreJugador = PlayerPrefs.GetString("NombreJugador");
        if (PlayerPrefs.HasKey("NombreJugador"))
        {
            CanvasNombreJugador.SetActive(false);
            canvasPerder.SetActive(true);
        } else
        {
            canvasPerder.SetActive(false);
            CanvasNombreJugador.SetActive(true);
        }


        HiScore.text = PlayerPrefs.GetInt("HiScore", 0).ToString();
        Time.timeScale = 0;
    }

    public void Perder()
    {

        puntuacion = LogicaPuntuacion.puntuacion;
        puntuacionTMP.SetText(puntuacion.ToString());

        canvasPerder.SetActive(true);
        Gameover.SetActive(true);
        reiniciar.SetActive(true);
        CanvasPuntuacion.SetActive(false);
        Score.SetActive(true);
        Puntuacion.SetActive(true);
        BestPuntuacion.SetActive(true);

        if (puntuacion > PlayerPrefs.GetInt("HiScore"))
        {
            PlayerPrefs.SetInt("HiScore", puntuacion);
            puntuacion = puntuacionMaxima;

        }

        if (puntuacion <= 8)
        {
            Bronze.SetActive(true);
        }
        else if (puntuacion >= 9 && puntuacion <= 16)
        {
            Plata.SetActive(true);
        } else if (puntuacion >= 16)
        {
            Oro.SetActive(true);
        }
        HiScore.text = PlayerPrefs.GetInt("HiScore", 0).ToString();
        audio.Stop();

        Leaderboard.SubmitScore(PlayerPrefs.GetInt("HiScore"), nombreJugador);


        Time.timeScale = 0;

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
        SkinBoton.SetActive(false);
        botonScoreboard.SetActive(false);



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
        nombreJugador = PlayerPrefs.GetString("NombreJugador");
        if (!PlayerPrefs.HasKey("NombreJugador"))
        {
            canvasPerder.SetActive(false);
            CanvasSkin.SetActive(false);
            CanvasNombreJugador.SetActive(true);
        }


        tiempo += Time.deltaTime;

        if (tiempo >= 15)
        {
            FondoDia.SetActive(false);
            FondoNoche.SetActive(true);

        }
    }

    public void CambiarSkin()
    {
        canvasPerder.SetActive(false);
        CanvasSkin.SetActive(true);

    }

    public void VolverMenuPrincipal()
    {
        CanvasSkin.SetActive(false);
        canvasPerder.SetActive(true);
        numeroSkin = Skin.NumeroSkin;

        Debug.Log(numeroSkin);
        if (numeroSkin == 1)
        {
            Flappo.SetActive(true);
            Flappo2.SetActive(false);
            Flappo3.SetActive(false);
        }
        if (numeroSkin == 2)
        {
            Flappo.SetActive(false);
            Flappo2.SetActive(true);
            Flappo3.SetActive(false);
        }

        if (numeroSkin == 3)
        {
            Flappo.SetActive(false);
            Flappo2.SetActive(false);
            Flappo3.SetActive(true);

        }

    }

    public void HighScores()
    {
        canvasPerder.SetActive(false);
        CanvasHighScores.SetActive(true);
        Leaderboard.recogerDatosTabla();
    }


    public void ConseguirNombre()
    {

        PlayerPrefs.SetString("NombreJugador", NombreJugador.text);

        canvasPerder.SetActive(true);
        CanvasNombreJugador.SetActive(false);

    }

    public void Atras()
    {
        CanvasHighScores.SetActive(false);
        canvasPerder.SetActive(true);
    }

    public void BorrarDatos()
    {
        PlayerPrefs.DeleteAll();
    }

}
