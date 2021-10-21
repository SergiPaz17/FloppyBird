using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscogerSkin : MonoBehaviour
{
    public GameObject Skin1;
    public GameObject Skin2;
    public GameObject Skin3;


    public int NumeroSkin = 1;

    public ControladorEscena escena;



    public void SkinUp()
    {
        NumeroSkin++;

        if(NumeroSkin == 4)
        {
            NumeroSkin = 1;
        }

        if(NumeroSkin == 1)
        {
            Skin1.SetActive(true);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
        }else if(NumeroSkin == 2)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(true);
            Skin3.SetActive(false);
        }
        else if(NumeroSkin == 3)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(true);
        }

    }

    public void SkinDown()
    {
        NumeroSkin--;

        if(NumeroSkin == 0)
        {
            NumeroSkin = 3;
        }

        if (NumeroSkin == 1)
        {
            Skin1.SetActive(true);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
        }
        else if (NumeroSkin == 2)
        {
            Skin2.SetActive(true);
            Skin1.SetActive(false);
            Skin3.SetActive(false);
        }
        else if (NumeroSkin == 3)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(true);
        }

    }

    public int ComprobarSkin()
    {
        Debug.Log(NumeroSkin);
        return NumeroSkin;
    }

}
