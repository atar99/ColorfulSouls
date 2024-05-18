using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Oyuncu : MonoBehaviour
{
    public GameObject OlumMenusuObj;
    public GameObject OyuncuObj;
    public GameObject DurdurMenuBtnobj;
    public GameObject HareketEtmeobj;
    public GameObject BitisMenusuObj;
    public GameObject OyuniciMuzik;
    public GameObject ButonKontrol;
    public GameObject JoystickKontrol;

    public bool olum;
    public bool bitis;

    public int Anahtar;
    public int ToplamOlumSayi;
    public Text ToplamOlumSayi_text;

    string secilikontrol;

    int bitenbolum;
    int enyuksekbolum;
    int SonBolum;
    int baslayanbolum;
    void Start()
    {
     
        Anahtar = 0;
        ToplamOlumSayi = PlayerPrefs.GetInt("ToplamOlumSayi");
        ToplamOlumSayi_text.text = ToplamOlumSayi.ToString();
        olum = false;
        bitis = false;
        enyuksekbolum = PlayerPrefs.GetInt("Bolum");
        secilikontrol = PlayerPrefs.GetString("Kontrol");

        if (secilikontrol == "buton")
        {
            ButonKontrol.SetActive(true);
            JoystickKontrol.SetActive(false);
        }
        else if (secilikontrol == "Joystick")
        {
            ButonKontrol.SetActive(false);
            JoystickKontrol.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D Temas)
    {
        if (Temas.gameObject.tag == "Dusman")
        {
            olum = true;
            if (olum)
            {
                DurdurMenuBtnobj.SetActive(false);
                OlumMenusuObj.SetActive(true);
                OyuncuObj.SetActive(false);
                HareketEtmeobj.SetActive(false);
                OyuniciMuzik.SetActive(false);
                ToplamOlumSayi++;
                PlayerPrefs.SetInt("ToplamOlumSayi", ToplamOlumSayi);
                ToplamOlumSayi_text.text = ToplamOlumSayi.ToString();
                SoundManagerScript.PlaySound("Olum");


            }
            Destroy(Temas.gameObject);
        }
        if (Temas.gameObject.tag == "KirmiziDuvar")
        {
            olum = true;
            if (olum)
            {
                DurdurMenuBtnobj.SetActive(false);
                OlumMenusuObj.SetActive(true);
                OyuncuObj.SetActive(false);
                HareketEtmeobj.SetActive(false);
                OyuniciMuzik.SetActive(false);
                ToplamOlumSayi++;
                PlayerPrefs.SetInt("ToplamOlumSayi", ToplamOlumSayi);
                ToplamOlumSayi_text.text = ToplamOlumSayi.ToString();
                SoundManagerScript.PlaySound("Olum");


            }
            Destroy(Temas.gameObject);
        }
        if (Temas.gameObject.tag == "Bitis")
        {
            if (Anahtar == 0) bitis = true;

            if (bitis)
            {
                OyuniciMuzik.SetActive(false);
                DurdurMenuBtnobj.SetActive(false);
                BitisMenusuObj.SetActive(true);
                HareketEtmeobj.SetActive(false);
                bitenbolum = SceneManager.GetActiveScene().buildIndex;
                Destroy(Temas.gameObject);
                if (bitenbolum > enyuksekbolum)
                {
                    PlayerPrefs.SetInt("Bolum", SceneManager.GetActiveScene().buildIndex);
                }

                OyuncuObj.SetActive(false);
                SoundManagerScript.PlaySound("Bitis");
            }
        }
        if (Temas.gameObject.tag == "Anahtar")
        {
            Anahtar = Anahtar - 1;
            Destroy(Temas.gameObject);
            SoundManagerScript.PlaySound("Anahtar");
        }

        if (Temas.gameObject.tag == "AnahtarArttirici")
        {
            Anahtar = Anahtar + 1;
            Destroy(Temas.gameObject);
        }
        if (Temas.gameObject.tag == "Baslangıc")
        {
            baslayanbolum = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("SonBolum",baslayanbolum);
        }

    }
    private void OnTriggerExit2D(Collider2D Temas)
    {
        if (Temas.gameObject.tag == "Baslangıc")
        {
            Destroy(Temas.gameObject);
        }
    }
}