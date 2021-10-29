using UnityEngine.UI;
using UnityEngine;
using LootLocker.Requests;
using TMPro;
public class Leadeboardcontroller : MonoBehaviour
{

    public ControladorEscena escena;

    public int ID;

    public int MaxScores = 10;

    public TMP_Text[] Entries;

    

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

    public void SubmitScore(int puntuacioMaxima ,string nombreJugador)
    {
        
        Debug.Log(puntuacioMaxima);
        LootLockerSDKManager.SubmitScore(nombreJugador, puntuacioMaxima, ID, (response)=>
        {
            if (response.success)
            {
                Debug.Log("Se a subido los datos a la base de datos");
            }
            else
            {
                Debug.Log("jaja no");
            }

        });
    }

    public void recogerDatosTabla()
    {
        LootLockerSDKManager.GetScoreList(ID, MaxScores, (response) =>
         {
             if (response.success)
             {
                 LootLockerLeaderboardMember[] scores = response.items;

                 for (int x = 0; x < scores.Length; x++)
                 {
                     Entries[x].text = scores[x].rank + ".       " + scores[x].member_id + "            "+ scores[x].score;
                 }

                 if (scores.Length < MaxScores)
                 {
                     for (int x = scores.Length; x < MaxScores; x++)
                     {
                         Entries[x].text = (x + 1).ToString() + ".   ";
                     }
                 }
                 else
                 {
                     Debug.Log("jaja no");
                 }
             }
         });

    }
}
