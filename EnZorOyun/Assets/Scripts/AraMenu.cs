using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AraMenu : MonoBehaviour
{
    public GameObject DurdurMenuobj;
    public GameObject DurdurBtnobj;
    public GameObject DilMenuobj;
    public GameObject KontrolMenuObj;
    public GameObject ZorlukMenuObj;

    public bool DurdurMenuAcik;
    public bool DurdurBtnobjAcik;
    public bool DilMenuAcik;
    public bool KontrolMenuAcik;
    public bool ZorlukMenuAcik;
  
    public void Start()
    {
        DurdurMenuAcik = false;
        DilMenuAcik = false;
        KontrolMenuAcik = false;
        DurdurBtnobjAcik = true;
        ZorlukMenuAcik = false;

    }

    void Update()
    {
     if(DurdurMenuAcik)
        {
            DurdurMenuobj.SetActive(true);
            DilMenuobj.SetActive(false);
            DurdurBtnobj.SetActive(false);
            Time.timeScale = 0f;
            KontrolMenuObj.SetActive(false);
            ZorlukMenuObj.SetActive(false);

        }
     else if(DilMenuAcik)
        {
            DurdurMenuobj.SetActive(false);
            DilMenuobj.SetActive(true);
            DurdurBtnobj.SetActive(false);
            Time.timeScale = 0f;
            KontrolMenuObj.SetActive(false);
            ZorlukMenuObj.SetActive(false);
        }
   else if (KontrolMenuAcik)
        {
            DurdurMenuobj.SetActive(false);
            DilMenuobj.SetActive(false);
            DurdurBtnobj.SetActive(false);
            Time.timeScale = 0f;
            KontrolMenuObj.SetActive(true);
            ZorlukMenuObj.SetActive(false);
        }  
     else if (ZorlukMenuAcik)
        {
            DurdurMenuobj.SetActive(false);
            DilMenuobj.SetActive(false);
            DurdurBtnobj.SetActive(false);
            Time.timeScale = 0f;
            KontrolMenuObj.SetActive(false);
            ZorlukMenuObj.SetActive(true);
        }
        else
        {
            DurdurMenuobj.SetActive(false);
            DilMenuobj.SetActive(false);
            DurdurBtnobj.SetActive(true);
            Time.timeScale = 1f;
            KontrolMenuObj.SetActive(false);
            ZorlukMenuObj.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            durdur();
        }
    }

    public void durdur()
    { 
        DurdurMenuAcik = true;
        DilMenuAcik = false;
        DurdurBtnobjAcik = false;
        SoundManagerScript.PlaySound("MenuAcik");
        KontrolMenuAcik = false;
        ZorlukMenuAcik = false;
    }

    public void devam()
    {
        DurdurMenuAcik = false;
        DilMenuAcik = false;
        DurdurBtnobjAcik = true;
        SoundManagerScript.PlaySound("MenuKapali");
        KontrolMenuAcik = false;
        ZorlukMenuAcik = false;
    }
    public void dilmenu()
    {
        DurdurMenuAcik = false;
        DilMenuAcik = true;
        DurdurBtnobjAcik = false;
        SoundManagerScript.PlaySound("MenuAcik");
        KontrolMenuAcik = false;
        ZorlukMenuAcik = false;
    }
    public void kontrolmenu()
    {
        DurdurMenuAcik = false;
        DilMenuAcik = false;
        DurdurBtnobjAcik = false;
        SoundManagerScript.PlaySound("MenuAcik");
        KontrolMenuAcik = true;
        ZorlukMenuAcik = false;
    }
    public void zorlukmenu()
    {
        DurdurMenuAcik = false;
        DilMenuAcik = false;
        DurdurBtnobjAcik = false;
        SoundManagerScript.PlaySound("MenuAcik");
        KontrolMenuAcik = false;
        ZorlukMenuAcik = true;
    }


    public void AnaMenu()
    {
        SceneManager.LoadScene("AnaMenu");
    }

    public void ilerlemeSifirla()
    {
        PlayerPrefs.DeleteKey("Bolum");
        PlayerPrefs.DeleteKey("ToplamOlumSayi");
        PlayerPrefs.DeleteKey("BolumSeri");
        PlayerPrefs.DeleteKey("SonBolum");
       // PlayerPrefs.DeleteKey("Zorluk");
       // PlayerPrefs.DeleteKey("Kontrol");
    }

    public void GizlilikPolitikasi()
    {
        Application.OpenURL("https://docs.google.com/document/d/1Jbdt0kAa2cjrUhwixf6ED6b9wNzsHMb3/edit?usp=sharing&ouid=113839964696816086978&rtpof=true&sd=true");
    }
}
