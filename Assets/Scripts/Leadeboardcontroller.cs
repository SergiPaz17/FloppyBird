using UnityEngine.UI;
using UnityEngine;
using LootLocker.Requests;

public class Leadeboardcontroller : MonoBehaviour
{

    public ControladorEscena escena;

    public InputField UserID, PlayerScore;

    public int ID;

  

    void Start()
    {
        LootLockerSDKManager.StartSession("Player",(response) =>
        {
            if (response.success)
            {
                Debug.Log("succes");
            }
            else
            {
                Debug.Log("jaja no");
            }

        });
    }

    public void SubmitScore(int puntacionmaxima, string nombreJugador)
    {
        LootLockerSDKManager.SubmitScore(nombreJugador, puntacionmaxima, ID, (response)=>
        {
            if (response.success)
            {
                Debug.Log("succes");
            }
            else
            {
                Debug.Log("jaja no");
            }

        });
    }
}
